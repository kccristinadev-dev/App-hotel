public reserva(){
 InitializeComponet();
}
private void voltar(object sender, EventArgs e){
try{
     Navigation.PopAsync();
}
catch (Exeption ex){
 DisplayArlert("Ops ",ex.mensagem, " ok");
}

}