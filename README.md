# Przykłady ze szkolenia WPF dla zaawansowanych


## Diagnostyka 

### Diagnostyka bindingu z użyciem Attached Properties

W bindingu należy dodać attached property _PresentationTraceSources.TraceLevel_ z przestrzeni _System.Diagnostics_.


~~~ xml
<Page x:Class="Sulmar.WPF.Advanced.WPFClient.Views.CustomerView"
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
      xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
      xmlns:diag="clr-namespace:System.Diagnostics;assembly=WindowsBase"
      mc:Ignorable="d"       
      DataContext="{Binding Source={StaticResource Locator}, Path=CustomerViewModel}" 
      Title="CustomerView">
      
      <Grid>
         <TextBox Text="{Binding FirstName, diag:PresentationTraceSources.TraceLevel=High}" Tag="First name" />
      </Grid>
</Page>    
~~~

### Diagnostyka bindingu w Visual Studio

'Tools -> Options -> Debugging -> Output Window -> WPF Trace Settings -> Data Binding'





