# WPF-example

Plain vanilla WPF example to navigate between user views.

In this example, `MainWindow.xaml` has this fragment:

```xml
<ContentControl x:Name="MainContentControl" Grid.Row="1"/>
```

and views are set dynamically using the `MainContentControl` property of the main window (see `AppManager.cs`).

This is a simple way that can be sufficient in small applications. For more complex scenarios,
consider the [MVVM Toolkit](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/) 
(at your own risk :wink:).