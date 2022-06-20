using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace CourseWorkTransport
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void RefreshTransportLbx()
        {
            TransportLbx.DataSource = null;
            TransportLbx.DataSource = Transport.Items.Values.ToList();
        }
        private void RefreshRouteLbx()
        {
            RouteLbx.DataSource = null;
            RouteLbx.DataSource = Route.Items.Values.ToList();
        }
        private void RefreshStationLbx()
        {
            StationLbx.DataSource = null;
            StationLbx.DataSource = Station.Items.Values.ToList();
        }
        private void RefreshRouteTransportLbx()
        {
            RouteTransportLbx.DataSource = null;
            if((Route)RouteLbx.SelectedItem != null) RouteTransportLbx.DataSource = ((Route)RouteLbx.SelectedItem).ListTransports;
        }

        private void RefreshTransportStationsLbx()
        {
            TransportStationsLbx.DataSource = null;
            TransportStationsLbx.DataSource = ((Transport)TransportLbx.SelectedItem)?.Route.Stations;
        }
        private void RefreshTransportTypeLbx()
        {
            TransportTypeLbx.DataSource = null;
            TransportTypeLbx.DataSource = TransportType.Items.Values.ToList();
        }
        private void RefreshTransportTypeTransportLbx()
        {
            TransportTypeTransportLbx.DataSource = null;
            TransportTypeTransportLbx.DataSource = ((TransportType)TransportTypeLbx.SelectedItem)?.Transports;
        }

        private void RefreshLinkedStations()
        {
            LinkedStationsLbx.DataSource = null;
            if (RouteLbx.SelectedItem != null) LinkedStationsLbx.DataSource = ((Route)RouteLbx.SelectedItem).Stations;
        }
        private void RefreshLinkedRoutes()
        {
            LinkedRoutesLbx.DataSource = null;
            if (StationLbx.SelectedItem != null) LinkedRoutesLbx.DataSource = ((Station)StationLbx.SelectedItem).Routes;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            string jsonTransportType = File.ReadAllText(@"D:\KPI\Курсач 1 курс\CourseWork.Data\json\TransportType.json");
            TransportType.Items = JsonConvert.DeserializeObject<Dictionary<Guid, TransportType>>(jsonTransportType);
            string jsonRoute = File.ReadAllText(@"D:\KPI\Курсач 1 курс\CourseWork.Data\json\Route.json");
            Route.Items = JsonConvert.DeserializeObject<Dictionary<Guid, Route>>(jsonRoute);
            string jsonStation = File.ReadAllText(@"D:\KPI\Курсач 1 курс\CourseWork.Data\json\Station.json");
            Station.Items = JsonConvert.DeserializeObject<Dictionary<Guid, Station>>(jsonStation);
            string jsonSharing = File.ReadAllText(@"D:\KPI\Курсач 1 курс\CourseWork.Data\json\Sharing.json");
            Sharing.Items = JsonConvert.DeserializeObject<Dictionary<Guid, Sharing>>(jsonSharing);
            string jsonTransport = File.ReadAllText(@"D:\KPI\Курсач 1 курс\CourseWork.Data\json\Transport.json");
            Transport.Items = JsonConvert.DeserializeObject<Dictionary<Guid, Transport>>(jsonTransport);

            NoAdminView();
            RefreshTransportLbx();
            RefreshRouteLbx();
            RefreshRouteTransportLbx();
            RefreshStationLbx();
            RefreshTransportLbx();
            RefreshTransportStationsLbx();
            RefreshTransportTypeLbx();
            RefreshTransportTypeTransportLbx();
        }
        private void AddTransportBtn_Click(object sender, EventArgs e)
        {
            if (RouteLbx.SelectedItem != null && TransportTypeLbx.SelectedItem != null && TransportTbx.Text !="")
            {
                new Transport(true) { Name = TransportTbx.Text, Route = (Route)RouteLbx.SelectedItem, TransportType = (TransportType)TransportTypeLbx.SelectedItem };
            }
            else
            {
                MessageBox.Show(
                 "Пусті поля(е)",
                 "Error",
               MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
             MessageBoxDefaultButton.Button1,
             MessageBoxOptions.DefaultDesktopOnly);
            }
            RefreshTransportLbx();
            RefreshRouteTransportLbx();
            RefreshTransportTypeTransportLbx();
        }
        private void AddStationBtn_Click_1(object sender, EventArgs e)
        {
            if(StationNameTbx.Text == "" || StationTimeTbx.Text == "")
            {
                MessageBox.Show(
                "Пусті поля(е)",
                "Error",
              MessageBoxButtons.OK,
                MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
             new Station(true) { Name = StationNameTbx.Text, Time = StationTimeTbx.Text };
           
            }
            RefreshStationLbx();
        }
        private void AddTransportTypeBtn_Click(object sender, EventArgs e)
        {
            if (TransportTypeNameTbx.Text == "" && TransportTypeInfoTbx.Text == "")
            {
                MessageBox.Show(
                  "Пусті поля(е)",
                  "Error",
                MessageBoxButtons.OK,
                  MessageBoxIcon.Error,
              MessageBoxDefaultButton.Button1,
              MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                new TransportType(true) { Name = TransportTypeNameTbx.Text, Info = TransportTypeInfoTbx.Text };

            }
            RefreshTransportTypeLbx();
            RefreshTransportTypeTransportLbx();
        }
        private void AddRouteBtn_Click_1(object sender, EventArgs e)
        {
            if (RouteTbx.Text == "")
            {
                MessageBox.Show(
                 "Пусті поля(е)",
                 "Error",
               MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
             MessageBoxDefaultButton.Button1,
             MessageBoxOptions.DefaultDesktopOnly);
            }
            else {new Route(true) { Name = RouteTbx.Text }; }
            
            RefreshRouteLbx();
        }
        private void EditTransportTypeBtn_Click(object sender, EventArgs e)
        {
            if (TransportTypeLbx.SelectedItem == null && TransportTypeInfoTbx.Text == "" && TransportTypeNameTbx.Text != "")
            {
                MessageBox.Show(
                 "Пусті поля(е)",
                 "Error",
               MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
             MessageBoxDefaultButton.Button1,
             MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                ((TransportType)TransportTypeLbx.SelectedItem).Name = TransportTypeNameTbx.Text;
                ((TransportType)TransportTypeLbx.SelectedItem).Info = TransportTypeInfoTbx.Text;
         
            }
            RefreshTransportTypeLbx();
            RefreshTransportTypeTransportLbx();
        }
        private void EditTransportBtn_Click(object sender, EventArgs e)
        {
            if (TransportTbx.Text != "")
            {
                ((Transport)TransportLbx.SelectedItem).Name = TransportTbx.Text;
            }
            else
            {
                MessageBox.Show(
                 "Пусті поля(е)",
                 "Error",
               MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
             MessageBoxDefaultButton.Button1,
             MessageBoxOptions.DefaultDesktopOnly);
            }
            if (RouteLbx.SelectedItem != null)
            {
                ((Transport)TransportLbx.SelectedItem).Route = (Route)RouteLbx.SelectedItem;
            }
            if (TransportTypeLbx.SelectedItem != null)
            {
                ((Transport)TransportLbx.SelectedItem).TransportType = (TransportType)TransportTypeLbx.SelectedItem;
            }
            RefreshTransportLbx();
            RefreshRouteTransportLbx();
            RefreshTransportTypeTransportLbx();
        }
        private void EditRouteBtn_Click(object sender, EventArgs e)
        {
            if(RouteTbx.Text == "")
            {
                MessageBox.Show(
                 "Пусті поля(е)",
                 "Error",
               MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
             MessageBoxDefaultButton.Button1,
             MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                ((Route)RouteLbx.SelectedItem).Name = RouteTbx.Text;
            }
            
            RefreshRouteLbx();
        }
        private void EditStationTbx_Click(object sender, EventArgs e)
        {
            if (StationNameTbx.Text == "" || StationTimeTbx.Text == "")
            {
                MessageBox.Show(
                "Пусті поля(е)",
                "Error",
              MessageBoxButtons.OK,
                MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                ((Station)StationLbx.SelectedItem).Name = StationNameTbx.Text;
                ((Station)StationLbx.SelectedItem).Time = StationTimeTbx.Text;
            }
            RefreshStationLbx();
        }
        private void DeleteTransportTypeBtn_Click(object sender, EventArgs e)
        {
            if (TransportTypeLbx.SelectedItem != null)
            {

                var s = ((TransportType)TransportTypeLbx.SelectedItem).Transports;
                foreach (var a in s)
                {
                    Transport.Items.Remove(a.Id);
                }
                TransportType.Items.Remove(
                    ((TransportType)TransportTypeLbx.SelectedItem).Id);
                
            }
            RefreshTransportLbx();
            RefreshRouteTransportLbx();
            RefreshTransportTypeLbx();
            RefreshTransportTypeTransportLbx();
        }
        private void DeleteTransportBtn_Click(object sender, EventArgs e)
        {
            if (TransportLbx.SelectedItem != null)
            {
                Transport.Items.Remove(((Transport)TransportLbx.SelectedItem).Id);
                RefreshTransportLbx();
                RefreshTransportTypeTransportLbx();
            }
        }
        private void DeleteRouteBtn_Click(object sender, EventArgs e)
        {
            var route = (Route)RouteLbx.SelectedItem;

            var s = Sharing.Items.Values.Where(shk => shk.Route == route).ToList();
            foreach (var a in s)
            {
                Sharing.Items.Remove(a.Id);
            }
            var b = ((Route)RouteLbx.SelectedItem).ListTransports.ToList();
            foreach (var a in b)
            {
                Transport.Items.Remove(a.Id);
            }
            Route.Items.Remove(((Route)RouteLbx.SelectedItem).Id);
            RefreshRouteLbx();
            RefreshTransportLbx();
        }
        private void DeleteStationTbx_Click(object sender, EventArgs e)
        {
            var station = (Station)StationLbx.SelectedItem;

            var s = Sharing.Items.Values.Where(shk => shk.Station == station).ToList();
            foreach(var a in s)
            {
               
                Sharing.Items.Remove(a.Id);
            }
            

            Station.Items.Remove(((Station)StationLbx.SelectedItem).Id);
            RefreshStationLbx();
            RefreshRouteLbx();
            RefreshTransportLbx();
            RefreshRouteTransportLbx();
            
        }

        private void RouteLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RouteLbx.SelectedItem != null)
            RouteTbx.Text = ((Route)RouteLbx.SelectedItem).Name;
            
            LinkedStationsLbx.DataSource = null;
            RouteTransportLbx.DataSource = null;
            if (RouteLbx.SelectedItem != null)
            {
                LinkedStationsLbx.DataSource = ((Route)RouteLbx.SelectedItem).Stations;
                RouteTransportLbx.DataSource = ((Route)RouteLbx.SelectedItem).ListTransports;
            }

        }

        private void StationLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(StationLbx.SelectedItem != null)
            {
                StationNameTbx.Text = ((Station)StationLbx.SelectedItem).Name;
                StationTimeTbx.Text = ((Station)StationLbx.SelectedItem).Time;
            }
            LinkedRoutesLbx.DataSource = null;
            StationTransportLbx.DataSource = null;
             
         
            var station = (Station)StationLbx.SelectedItem;
            var existingSharing = Sharing.Items.Values.Where(sh => sh.Station == station).ToList();

            if (StationLbx.SelectedItem != null)
            {
                LinkedRoutesLbx.DataSource = ((Station)StationLbx.SelectedItem).Routes;
               var StationTransportList = new List<Transport>();
                foreach( var a in existingSharing)
                {
                    foreach (var c in a.Route.ListTransports)
                    {
                        StationTransportList.Add(c);
                    }
                }
                StationTransportLbx.DataSource = StationTransportList;
                StationTransportList.Clear();
            }

        }

       
        private void RouteStationLinkBtn_Click(object sender, EventArgs e)
        {
            var route = (Route)RouteLbx.SelectedItem;
            var station = (Station)StationLbx.SelectedItem;
            var existingSharing = Sharing.Items.Values.Where(sh => sh.Route == route && sh.Station == station).FirstOrDefault();
            if(existingSharing == null)
            new Sharing((Route)RouteLbx.SelectedItem, (Station)StationLbx.SelectedItem, true);
            
            RefreshLinkedRoutes();
            RefreshLinkedStations();
            RefreshTransportStationsLbx();
        }

        private void RouteStationDislinkBtn_Click(object sender, EventArgs e)
        {
            var route = (Route)RouteLbx.SelectedItem;
            var station = (Station)StationLbx.SelectedItem;
            var sharingToDel = Sharing.Items.Values.Where(sh => sh.Route == route && sh.Station == station).FirstOrDefault();
            if(sharingToDel != null)
            {
                Sharing.Items.Remove(sharingToDel.Id);
            }
            RefreshLinkedRoutes();
            RefreshLinkedStations();
            RefreshTransportStationsLbx();

        }

        private void TransportLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(TransportLbx.SelectedItem != null)
            {
                TransportRouteTbx.Text = ((Transport)TransportLbx.SelectedItem).Route.ToString();
                TransportTbx.Text = ((Transport)TransportLbx.SelectedItem).Name;
                TransportTypeTbx.Text = ((Transport)TransportLbx.SelectedItem).TransportType.Name;
                TransportInfoTbx.Text = ((Transport)TransportLbx.SelectedItem).TransportType.Info;
                
                RefreshTransportStationsLbx();
            }
        }

        private void TransportTypeLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TransportTypeLbx.SelectedItem != null)
            {
                TransportTypeNameTbx.Text = ((TransportType)TransportTypeLbx.SelectedItem).Name;
                TransportTypeInfoTbx.Text = ((TransportType)TransportTypeLbx.SelectedItem).Info;
                RefreshTransportTypeTransportLbx();
            }
        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sharing.Serialiaze("Sharing");
            TransportType.Serialiaze("TransportType");
            Route.Serialiaze("Route");
            Station.Serialiaze("Station");
            Transport.Serialiaze("Transport");
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            //  AdminPassword_Load(sender, e);
           if(AdminPasswordTbx.Text == "1234")
            {
                AdminView();
                AdminPasswordTbx.Enabled = false;
                AdminPasswordTbx.Visible = false;
                AdminBtn.Enabled = false;
                AdminBtn.Visible = false;
                label6.Visible = false;
            }
            else
            {
                MessageBox.Show(
                 "Invalid Password",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);
            }
            
            
        }
        private void NoAdminView()
        {
            TransportTypeNameTbx.ReadOnly = true;
            TransportTypeInfoTbx.ReadOnly = true;
            AddTransportTypeBtn.Enabled = false;
            AddTransportTypeBtn.Visible = false;
            EditTransportTypeBtn.Enabled = false;
            EditTransportTypeBtn.Visible = false;
            DeleteTransportTypeBtn.Enabled = false;
            DeleteTransportTypeBtn.Visible = false;
            TransportTbx.ReadOnly = true;

            AddTransportBtn.Enabled = false;
            AddTransportBtn.Visible = false;
            EditTransportBtn.Enabled = false;
            EditTransportBtn.Visible = false;
            DeleteTransportBtn.Enabled = false;
            DeleteTransportBtn.Visible = false;

            AddRouteBtn.Enabled = false;
            AddRouteBtn.Visible = false;
            EditRouteBtn.Enabled = false;
            EditRouteBtn.Visible = false;
            DeleteRouteBtn.Enabled = false;
            DeleteRouteBtn.Visible = false;

            StationNameTbx.ReadOnly = true;
            StationTimeTbx.ReadOnly = true;

            AddStationBtn.Enabled = false;
            AddStationBtn.Visible = false;
            EditStationTbx.Enabled = false;
            EditStationTbx.Visible = false;
            DeleteStationTbx.Enabled = false;
            DeleteStationTbx.Visible = false;

            RouteStationLinkBtn.Enabled = false;
            RouteStationLinkBtn.Visible = false; 

            RouteStationDislinkBtn.Enabled = false;
            RouteStationDislinkBtn.Visible = false;
        }
        private void AdminView()
        {
            TransportTypeNameTbx.ReadOnly = false;
            TransportTypeInfoTbx.ReadOnly = false;
            AddTransportTypeBtn.Enabled = true;
            AddTransportTypeBtn.Visible = true;
            EditTransportTypeBtn.Enabled = true;
            EditTransportTypeBtn.Visible = true;
            DeleteTransportTypeBtn.Enabled = true;
            DeleteTransportTypeBtn.Visible = true;
            TransportTbx.ReadOnly = false;

            AddTransportBtn.Enabled = true;
            AddTransportBtn.Visible = true;
            EditTransportBtn.Enabled = true;
            EditTransportBtn.Visible = true;
            DeleteTransportBtn.Enabled = true;
            DeleteTransportBtn.Visible = true;

            AddRouteBtn.Enabled = true;
            AddRouteBtn.Visible = true;
            EditRouteBtn.Enabled = true;
            EditRouteBtn.Visible = true;
            DeleteRouteBtn.Enabled = true;
            DeleteRouteBtn.Visible = true;

            StationNameTbx.ReadOnly = false;
            StationTimeTbx.ReadOnly = false;

            AddStationBtn.Enabled = true;
            AddStationBtn.Visible = true;
            EditStationTbx.Enabled = true;
            EditStationTbx.Visible = true;
            DeleteStationTbx.Enabled = true;
            DeleteStationTbx.Visible = true;

            RouteStationLinkBtn.Enabled = true;
            RouteStationLinkBtn.Visible = true;

            RouteStationDislinkBtn.Enabled = true;
            RouteStationDislinkBtn.Visible = true;
        }
    }
}
