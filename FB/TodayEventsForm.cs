using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using FacebookWrapper.ObjectModel;
using MosaicGenerator;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;

namespace FB
{
    public partial class TodayEventsForm : MasterForm
    {
        private readonly List<Event> r_TodayEvents;
        private PointLatLng m_UserLocation;
        private GMapOverlay m_routesOverlay;

        public TodayEventsForm(User i_User)
            : base(i_User)
        {
            InitializeComponent();
            r_TodayEvents = new List<Event>();
            m_routesOverlay = new GMapOverlay("routes");
        }

        private void TodayEventsForm_Load(object sender, EventArgs e)
        {
            this.buttonTodayEvents.BackColor = Color.LightGray;

            listBoxEvents.BeginInvoke(new Action(initTodayEvents));
        }

        private void initTodayEvents()
        {
            foreach (Event currentEvent in m_User.Events)
            {
                // use first if statement for the real purpose the second for testing
                // if (currentEvent.Place != null && !string.IsNullOrWhiteSpace(currentEvent.Place.Name))
                if (currentEvent.Place != null && !string.IsNullOrWhiteSpace(currentEvent.Place.Name) && currentEvent.StartTime.Value > DateTime.Now)
                {
                    r_TodayEvents.Add(currentEvent);
                }
            }

            listBoxEvents.DisplayMember = "Name";
            listBoxEvents.DataSource = r_TodayEvents;
            listBoxEvents.SelectedIndex = -1;
            listBoxEvents.SelectedIndexChanged += listBoxEvents_SelectedIndexChanged;
            initMap();
        }

        private void initMap()
        {
            gMapControlEvents.MapProvider = GoogleMapProvider.Instance;
            gMapControlEvents.DragButton = MouseButtons.Left;

            GMapOverlay markersOverlay = new GMapOverlay("markers");
            foreach (Event todayEvent in r_TodayEvents)
            {
                GeoCoderStatusCode status;

                PointLatLng? point = GoogleMapProvider.Instance.GetPoint(todayEvent.Place.Name, out status);
                if (point.HasValue)
                {
                    GMarkerGoogle marker = new GMarkerGoogle(point.Value, GMarkerGoogleType.green);
                    markersOverlay.Markers.Add(marker);
                }
            }

            gMapControlEvents.Overlays.Add(markersOverlay);
            gMapControlEvents.Zoom = 1;
        }

        private void TodayEventsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gMapControlEvents.Manager.CancelTileCaching();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            GeoCoderStatusCode status;
            PointLatLng? point = GoogleMapProvider.Instance.GetPoint(textBoxCurrentLocation.Text, out status);

            if(!point.HasValue)
            {
                MessageBox.Show("Your current location was not found");
            }
            else
            {
                m_UserLocation = point.Value;
                gMapControlEvents.Position = point.Value;
                gMapControlEvents.Zoom = 15;
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            GeoCoderStatusCode geoCoderStatus;
            PointLatLng? point = GoogleMapProvider.Instance.GetPoint(((Event)listBoxEvents.SelectedValue).Place.Name, out geoCoderStatus);

            if (!point.HasValue)
            {
                MessageBox.Show("Could not find the event location");
            }
            else
            {
                if (m_UserLocation != PointLatLng.Empty)
                {
                    GDirections directions;
                    DirectionsStatusCode directionStatus = GoogleMapProvider.Instance.GetDirections(out directions, m_UserLocation, point.Value, false, false, false, false, true);
                    if (directions != null)
                    {
                        GMapRoute mapRoute = new GMapRoute(directions.Route, "route");
                        m_routesOverlay.Routes.Clear();
                        m_routesOverlay.Routes.Add(mapRoute);
                        gMapControlEvents.Overlays.Remove(m_routesOverlay);
                        gMapControlEvents.Overlays.Add(m_routesOverlay);
                    }
                    else
                    {
                        MessageBox.Show("There is no route between these points");
                    }
                }

                gMapControlEvents.Position = point.Value;
                gMapControlEvents.Zoom = 15;
            }
        }
    }
}