using SlimGis.MapKit.Geometries;
using System.Windows;
using System.Windows.Controls;

namespace SlimGis.Samples
{
    public partial class EditGeometryView : UserControl
    {
        public EditGeometryView()
        {
            InitializeComponent();
        }

        private void Map1_Loaded(object sender, RoutedEventArgs e)
        {
            Map1.MapUnit = GeoUnit.Meter;
            Map1.UseOpenStreetMapAsBaseMap();

            GeoBound bound = (GeoBound)Map1.MaxBound.Clone();
            bound.ScaleDown(60);
            Map1.Behaviors.EditBehavior.Features.Add(new Feature(bound));

            Map1.ZoomToFullBound();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            Map1.Behaviors.EditBehavior.Refresh();
        }
    }
}
