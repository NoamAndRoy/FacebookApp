using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;

namespace FB
{
    public partial class TodayEventsForm : MasterForm
    {
        private GPSFacade r_GPS;

        public TodayEventsForm()
            : base()
        {
            InitializeComponent();
            r_GPS = new GPSFacade(gMapControlEvents);
        }

        protected override void initialize()
        {
            base.initialize();

            this.buttonTodayEvents.BackColor = Color.LightGray;

            Thread thread = new Thread(new ThreadStart(initTodayEvents));
            thread.Start();
        }

        private void initTodayEvents()
        {
            List<Event> todayEvents = new List<Event>();
            List<string> locations = new List<string>();

            foreach (Event currentEvent in LoggedInUser.Instance.Events)
            {
                // use first if statement for the real purpose the second for testing
                // if (currentEvent.Place != null && !string.IsNullOrWhiteSpace(currentEvent.Place.Name))
                if (currentEvent.Place != null && !string.IsNullOrWhiteSpace(currentEvent.Place.Name) && currentEvent.StartTime.Value > DateTime.Now)
                {
                    todayEvents.Add(currentEvent);
                    locations.Add(currentEvent.Place.Name);
                }
            }

            listBoxEvents.Invoke(new Action(
                () =>
                {
                    listBoxEvents.DisplayMember = "Name";
                    listBoxEvents.DataSource = todayEvents;
                    listBoxEvents.SelectedIndex = -1;
                    listBoxEvents.SelectedIndexChanged += listBoxEvents_SelectedIndexChanged;

                    r_GPS.InitMapAndLocations(locations, GMarkerGoogleType.green);
                }));
        }

        private void todayEventsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gMapControlEvents.Manager.CancelTileCaching();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            PointLatLng point = GPSFacade.GetLocationByName(textBoxCurrentLocation.Text);

            if(point.IsEmpty)
            {
                MessageBox.Show("Your current location was not found");
            }
            else
            {
                r_GPS.UserLocation = point;
                gMapControlEvents.Position = point;
                gMapControlEvents.Zoom = 15;
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                r_GPS.DrawRouteFromUserLocation(((Event)listBoxEvents.SelectedValue).Place.Name);
                labelError.Text = string.Empty;
            }
            catch(Exception exception)
            {
                labelError.Text = exception.Message;
            }
        }
    }
}