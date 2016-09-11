using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace FB
{
    public class GPSFacade
    {
        private readonly GMapControl r_Map;

        private readonly GMapOverlay r_routesOverlay;

        public PointLatLng UserLocation { get; set; }

        public GMapControl MapControl
        {
            get { return r_Map; }
        }

        public GPSFacade(GMapControl i_Map)
        {
            r_Map = i_Map;
            r_routesOverlay = new GMapOverlay("routes");
        }

        public static PointLatLng GetLocationByName(string i_Location)
        {
            GeoCoderStatusCode status;
            PointLatLng? point = GoogleMapProvider.Instance.GetPoint(i_Location, out status);
            PointLatLng pointToReturn = PointLatLng.Empty;

            if (point.HasValue)
            {
                pointToReturn = point.Value;
            }

            return pointToReturn;
        }

        public void InitMapAndLocations(List<string> i_Locations, GMarkerGoogleType i_MakrerType)
        {
            MapControl.MapProvider = GoogleMapProvider.Instance;
            MapControl.DragButton = MouseButtons.Left;

            if (i_Locations != null)
            {
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                foreach (string location in i_Locations)
                {
                    GeoCoderStatusCode status;

                    PointLatLng? point = GoogleMapProvider.Instance.GetPoint(location, out status);
                    if (point.HasValue)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(point.Value, i_MakrerType);
                        markersOverlay.Markers.Add(marker);
                    }
                }

                MapControl.Overlays.Add(markersOverlay);
            }

            MapControl.Zoom = 1;
        }

        public void CloseMap()
        {
            MapControl.Manager.CancelTileCaching();
        }

        public void GetRouteFromUserLocation(string i_Location)
        {
            PointLatLng location = GetLocationByName(i_Location);

            if (location.IsEmpty)
            {
                throw new ArgumentException("Could not find the location you entered");
            }
            else
            {
                if (UserLocation != PointLatLng.Empty)
                {
                    GDirections directions;
                    DirectionsStatusCode directionStatus = GoogleMapProvider.Instance.GetDirections(out directions, UserLocation, location, false, false, false, false, true);
                    if (directions != null)
                    {
                        GMapRoute mapRoute = new GMapRoute(directions.Route, "route");
                        r_routesOverlay.Routes.Clear();
                        r_routesOverlay.Routes.Add(mapRoute);
                        r_Map.Overlays.Remove(r_routesOverlay);
                        r_Map.Overlays.Add(r_routesOverlay);
                    }
                    else
                    {
                        throw new Exception("There is no route between these points");
                    }
                }

                r_Map.Position = location;
                r_Map.Zoom = 15;
            }
        }
    }
}