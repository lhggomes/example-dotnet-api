namespace ApiCrud.estudantes

{ }

public static class EstudanteRotas
{
    public static void AddRotasEstudantes(this WebApplication app)
    {
        app.MapGet("estudantes", () => "Hello Estudantes");
    }

}