public reserva(){
 InitializeComponet();
}
private async void voltar(object sender, EventArgs e){
try{
     await Navigation.PopAsync();
}
catch (Exception ex){
await DisplayAlert("Ops ",ex.Mensagem, " ok");
}

}