namespace ClinicaOdontologica.API.Data
{
    using Microsoft.EntityFrameworkCore;

    public class ClinicaOdontologicaAPIContext(DbContextOptions<ClinicaOdontologicaAPIContext> options) : DbContext(options)
    {
        public DbSet<ClinicaOdontologica.Modelos.Cita> Cita { get; set; } = default!;
        public DbSet<ClinicaOdontologica.Modelos.Consultorio> Consultorio { get; set; } = default!;
        public DbSet<ClinicaOdontologica.Modelos.DetallesCita> DetallesCita { get; set; } = default!;
        public DbSet<ClinicaOdontologica.Modelos.Especialidad> Especialidad { get; set; } = default!;
        public DbSet<ClinicaOdontologica.Modelos.Factura> Factura { get; set; } = default!;
        public DbSet<ClinicaOdontologica.Modelos.HistorialMedico> HistorialMedico { get; set; } = default!;
        public DbSet<ClinicaOdontologica.Modelos.Odontologo> Odontologo { get; set; } = default!;
        public DbSet<ClinicaOdontologica.Modelos.Paciente> Paciente { get; set; } = default!;
        public DbSet<ClinicaOdontologica.Modelos.Receta> Receta { get; set; } = default!;
        public DbSet<ClinicaOdontologica.Modelos.Tratamiento> Tratamiento { get; set; } = default!;
    }
}