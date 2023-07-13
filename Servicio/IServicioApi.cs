using F1Blazor2.Models;
namespace F1Blazor2.Servicio
{
    public interface IServicioApi
    {
        //Pilotos
        Task<List<PilotoEnteroDTO>> GetPilotos();

        Task<PilotoDTO> GetPiloto(int id);

        Task<bool> CrearPiloto(CrearPilotoDTO modelo);

        Task<bool> ActualizarPiloto(int id, PilotoToUpdateDTO modelo);

        Task<bool> EliminarPiloto(int id);

        Task<List<int>> GetDorsalesDisponibles();

        //Escuderias
        Task<List<EscuderiumEnteroDTO>> GetEscuderias();

        Task<EscuderiumDTO> GetEscuderia(int id);

        Task<bool> CrearEscuderia(CrearEscuderiumDTO modelo);

        Task<bool> ActualizarEscuderia(int id, EscuderiumDTOUpdate modelo);

        Task<bool> EliminarEscuderia(int id);

        Task<List<EscuderiasId>> GetEscuderiasId();

        //Carreras
        Task<List<CarreraEnteraDTO>> GetCarreras();

        Task<CarreraDTO> GetCarrera(int id);

        Task<bool> CrearCarrera(CrearCarreraDTO modelo);

        Task<bool> ActualizarCarrera(int id, CarreraDTOUpdate modelo);

        Task<bool> EliminarCarrera(int id);

        //Clasificacion
        Task<List<Clasificacion>> GetClasificacion();


    }
}
