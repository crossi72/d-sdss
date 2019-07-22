Imports Microsoft.Maps.MapControl.WPF

Public Class mapSupport

	Public Structure coordinate
		Dim latitude As Double
		Dim longitude As Double

		Public Sub New(latitude As Double, longitude As Double)
			Me.latitude = latitude
			Me.longitude = longitude
		End Sub
	End Structure

	Public Shared Sub AddNewPolygon(myMap As Map, x As coordinate, y As coordinate, z As coordinate)
		Dim polygon As New MapPolygon() With _
		{.Fill = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Blue), _
		  .Stroke = New System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Green), _
		  .StrokeThickness = 5, _
		  .Opacity = 0.7, _
		  .Locations = New LocationCollection() _
		}

		polygon.Locations.Add(New Location(x.latitude, x.longitude))
		polygon.Locations.Add(New Location(y.latitude, y.longitude))
		polygon.Locations.Add(New Location(z.latitude, z.longitude))

		myMap.Children.Add(polygon)
	End Sub

End Class
