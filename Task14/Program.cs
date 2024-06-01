using Task14;

TrafficLights trafficLight = new TrafficLights(TrafficLights.Color.Yellow);

Console.WriteLine($"Current Color: {trafficLight.GetCurrentColor()}");
trafficLight.ChangeColor();
Console.WriteLine(trafficLight.GetCurrentColor());
trafficLight.ChangeColor();
Console.WriteLine(trafficLight.GetCurrentColor());
trafficLight.ChangeColor();
Console.WriteLine(trafficLight.GetCurrentColor());