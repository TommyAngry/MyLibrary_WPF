// See https://aka.ms/new-console-template for more information


using MyLibrary_WPF;

Console.WriteLine("Hello, World!");
Calculations calculation = new Calculations();

TimeSpan time = new TimeSpan(10, 0, 00);
TimeSpan time_2 = new TimeSpan(0, 30, 00);
TimeSpan timeSuma = time + time_2;

Console.WriteLine(timeSuma.Hours +" "+timeSuma.Minutes + " " +timeSuma.Seconds  );