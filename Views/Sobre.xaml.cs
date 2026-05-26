public partial class Reserva : ContentPage
{
public Reserva(){
 InitializeComponent();
}
private async void voltar(object sender, EventArgs e){
try{
     await Navigation.PopAsync();
}
catch (Exception ex){
await DisplayAlert("Ops ",ex.Message, " ok");
}

}
}