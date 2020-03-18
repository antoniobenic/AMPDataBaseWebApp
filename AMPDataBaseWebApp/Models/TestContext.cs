using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AMPDataBaseWebApp.Models
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirTemp5cm> AirTemp5cm { get; set; }
        public virtual DbSet<AirTemp5cmParsing> AirTemp5cmParsing { get; set; }
        public virtual DbSet<AtmPressParsing> AtmPressParsing { get; set; }
        public virtual DbSet<AtmPressureMetaData> AtmPressureMetaData { get; set; }
        public virtual DbSet<AtmosphericPressure> AtmosphericPressure { get; set; }
        public virtual DbSet<DiffuseRadiation> DiffuseRadiation { get; set; }
        public virtual DbSet<GeoHumidity> GeoHumidity { get; set; }
        public virtual DbSet<GeoHumidityParsing> GeoHumidityParsing { get; set; }
        public virtual DbSet<GeoTemp10cm> GeoTemp10cm { get; set; }
        public virtual DbSet<GeoTemp10cmParsing> GeoTemp10cmParsing { get; set; }
        public virtual DbSet<GeoTemp20cm> GeoTemp20cm { get; set; }
        public virtual DbSet<GeoTemp20cmParsing> GeoTemp20cmParsing { get; set; }
        public virtual DbSet<GeoTemp5cm> GeoTemp5cm { get; set; }
        public virtual DbSet<GeoTemp5cmParsing> GeoTemp5cmParsing { get; set; }
        public virtual DbSet<GlobalRadiation> GlobalRadiation { get; set; }
        public virtual DbSet<Humidity> Humidity { get; set; }
        public virtual DbSet<HumidityMetaData> HumidityMetaData { get; set; }
        public virtual DbSet<HumidityParsing> HumidityParsing { get; set; }
        public virtual DbSet<Precipitation> Precipitation { get; set; }
        public virtual DbSet<PrecipitationMetaData> PrecipitationMetaData { get; set; }
        public virtual DbSet<PrecipitationParsing> PrecipitationParsing { get; set; }
        public virtual DbSet<RadiationMetaData> RadiationMetaData { get; set; }
        public virtual DbSet<RadiationParsing> RadiationParsing { get; set; }
        public virtual DbSet<Seatemperature> Seatemperature { get; set; }
        public virtual DbSet<SeatemperatureParsing> SeatemperatureParsing { get; set; }
        public virtual DbSet<SensorElevation> SensorElevation { get; set; }
        public virtual DbSet<Station> Station { get; set; }
        public virtual DbSet<SunDuration> SunDuration { get; set; }
        public virtual DbSet<Temperature> Temperature { get; set; }
        public virtual DbSet<TemperatureMetaData> TemperatureMetaData { get; set; }
        public virtual DbSet<TemperatureParsing> TemperatureParsing { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Uvb> Uvb { get; set; }
        public virtual DbSet<Wind> Wind { get; set; }
        public virtual DbSet<WindLvl2> WindLvl2 { get; set; }
        public virtual DbSet<WindLvl2Parsing> WindLvl2Parsing { get; set; }
        public virtual DbSet<WindMetaData> WindMetaData { get; set; }
        public virtual DbSet<WindParsing> WindParsing { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=172.20.0.64;Username=postgres;Password=Thiothixene;Database=Test");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirTemp5cm>(entity =>
            {
                entity.ToTable("air_temp_5cm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasColumnType("numeric");

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasColumnType("numeric");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Max)
                    .HasColumnName("max")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxTime)
                    .HasColumnName("max_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Min)
                    .HasColumnName("min")
                    .HasColumnType("numeric");

                entity.Property(e => e.MinTime)
                    .HasColumnName("min_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.AirTemp5cm)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("air_temp_5cm_fk_station_id_fkey");
            });

            modelBuilder.Entity<AirTemp5cmParsing>(entity =>
            {
                entity.ToTable("air_temp_5cm_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.AirTemp5cmParsing)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("air_temp_5cm_parsing_fk_station_id_fkey");
            });

            modelBuilder.Entity<AtmPressParsing>(entity =>
            {
                entity.ToTable("atm_press_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Current)
                    .IsRequired()
                    .HasColumnName("current");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("'.TLK'::bpchar");

                entity.Property(e => e.Max)
                    .IsRequired()
                    .HasColumnName("max");

                entity.Property(e => e.MaxTime)
                    .IsRequired()
                    .HasColumnName("max_time");

                entity.Property(e => e.Min)
                    .IsRequired()
                    .HasColumnName("min");

                entity.Property(e => e.MinTime)
                    .IsRequired()
                    .HasColumnName("min_time");
            });

            modelBuilder.Entity<AtmPressureMetaData>(entity =>
            {
                entity.ToTable("atm_pressure_meta_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.LocalisedName)
                    .HasColumnName("localised_name")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SensorHeight).HasColumnName("sensor_height");

                entity.Property(e => e.TargetTableName)
                    .HasColumnName("target_table_name")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.AtmPressureMetaData)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("atm_pressure_meta_data_fk_station_id_fkey");
            });

            modelBuilder.Entity<AtmosphericPressure>(entity =>
            {
                entity.ToTable("atmospheric_pressure");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasColumnType("numeric");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Max)
                    .HasColumnName("max")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxTime)
                    .HasColumnName("max_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Min)
                    .HasColumnName("min")
                    .HasColumnType("numeric");

                entity.Property(e => e.MinTime)
                    .HasColumnName("min_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.AtmosphericPressure)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("atm_press_FK_station_id_fkey");
            });

            modelBuilder.Entity<DiffuseRadiation>(entity =>
            {
                entity.ToTable("diffuse_radiation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("numeric");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.DiffuseRadiation)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("diffuse_radiation_fk_station_id_fkey");
            });

            modelBuilder.Entity<GeoHumidity>(entity =>
            {
                entity.ToTable("geo_humidity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avg).HasColumnName("avg");

                entity.Property(e => e.Current).HasColumnName("current");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Max).HasColumnName("max");

                entity.Property(e => e.MaxTime)
                    .HasColumnName("max_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Min).HasColumnName("min");

                entity.Property(e => e.MinTime)
                    .HasColumnName("min_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.GeoHumidity)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("geo_humidity_fk_station_id_fkey");
            });

            modelBuilder.Entity<GeoHumidityParsing>(entity =>
            {
                entity.ToTable("geo_humidity_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.GeoHumidityParsing)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("geo_humidity_parsing_fk_station_id_fkey");
            });

            modelBuilder.Entity<GeoTemp10cm>(entity =>
            {
                entity.ToTable("geo_temp_10cm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasColumnType("numeric");

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasColumnType("numeric");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Max)
                    .HasColumnName("max")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxTime)
                    .HasColumnName("max_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Min)
                    .HasColumnName("min")
                    .HasColumnType("numeric");

                entity.Property(e => e.MinTime)
                    .HasColumnName("min_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.GeoTemp10cm)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("geo_temp_10cm_fk_station_id_fkey");
            });

            modelBuilder.Entity<GeoTemp10cmParsing>(entity =>
            {
                entity.ToTable("geo_temp_10cm_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.GeoTemp10cmParsing)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("geo_temp_10cm_parsing_fk_station_id_fkey");
            });

            modelBuilder.Entity<GeoTemp20cm>(entity =>
            {
                entity.ToTable("geo_temp_20cm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasColumnType("numeric");

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasColumnType("numeric");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Max)
                    .HasColumnName("max")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxTime)
                    .HasColumnName("max_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Min)
                    .HasColumnName("min")
                    .HasColumnType("numeric");

                entity.Property(e => e.MinTime)
                    .HasColumnName("min_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.GeoTemp20cm)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("geo_temp_20cm_fk_station_id_fkey");
            });

            modelBuilder.Entity<GeoTemp20cmParsing>(entity =>
            {
                entity.ToTable("geo_temp_20cm_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.GeoTemp20cmParsing)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("geo_temp_20cm_parsing_fk_station_id_fkey");
            });

            modelBuilder.Entity<GeoTemp5cm>(entity =>
            {
                entity.ToTable("geo_temp_5cm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasColumnType("numeric");

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasColumnType("numeric");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Max)
                    .HasColumnName("max")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxTime)
                    .HasColumnName("max_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Min)
                    .HasColumnName("min")
                    .HasColumnType("numeric");

                entity.Property(e => e.MinTime)
                    .HasColumnName("min_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.GeoTemp5cm)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("geo_temp_5cm_fk_station_id_fkey");
            });

            modelBuilder.Entity<GeoTemp5cmParsing>(entity =>
            {
                entity.ToTable("geo_temp_5cm_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.GeoTemp5cmParsing)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("geo_temp_5cm_parsing_fk_station_id_fkey");
            });

            modelBuilder.Entity<GlobalRadiation>(entity =>
            {
                entity.ToTable("global_radiation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("numeric");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.GlobalRadiation)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("global_radiation_fk_station_id_fkey");
            });

            modelBuilder.Entity<Humidity>(entity =>
            {
                entity.ToTable("humidity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avg).HasColumnName("avg");

                entity.Property(e => e.Current).HasColumnName("current");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Max).HasColumnName("max");

                entity.Property(e => e.MaxTime)
                    .HasColumnName("max_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Min).HasColumnName("min");

                entity.Property(e => e.MinTime)
                    .HasColumnName("min_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.Humidity)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("humidity_fk_station_id_fkey");
            });

            modelBuilder.Entity<HumidityMetaData>(entity =>
            {
                entity.ToTable("humidity_meta_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.LocalisedName)
                    .HasColumnName("localised_name")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SensorHeight)
                    .HasColumnName("sensor_height")
                    .HasColumnType("numeric");

                entity.Property(e => e.TargetTableName)
                    .HasColumnName("target_table_name")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.HumidityMetaData)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("humidity_meta_data_fk_station_id_fkey");
            });

            modelBuilder.Entity<HumidityParsing>(entity =>
            {
                entity.ToTable("humidity_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avg)
                    .IsRequired()
                    .HasColumnName("avg");

                entity.Property(e => e.Current)
                    .IsRequired()
                    .HasColumnName("current");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("'.RV1'::bpchar");

                entity.Property(e => e.Max)
                    .IsRequired()
                    .HasColumnName("max");

                entity.Property(e => e.MaxTime)
                    .IsRequired()
                    .HasColumnName("max_time");

                entity.Property(e => e.Min)
                    .IsRequired()
                    .HasColumnName("min");

                entity.Property(e => e.MinTime).HasColumnName("min_time");
            });

            modelBuilder.Entity<Precipitation>(entity =>
            {
                entity.ToTable("precipitation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FirstFiveMin)
                    .HasColumnName("first_five_min")
                    .HasColumnType("numeric");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.IsStationWorking).HasColumnName("is_station_working");

                entity.Property(e => e.SecondFiveMin)
                    .HasColumnName("second_five_min")
                    .HasColumnType("numeric");

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("numeric");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.Precipitation)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("precipitation_fk_station_id_fkey");
            });

            modelBuilder.Entity<PrecipitationMetaData>(entity =>
            {
                entity.ToTable("precipitation_meta_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.LocalisedName)
                    .HasColumnName("localised_name")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SensorHeight).HasColumnName("sensor_height");

                entity.Property(e => e.TargetTableName)
                    .HasColumnName("target_table_name")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.PrecipitationMetaData)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("precipitation_meta_data_fk_station_id_fkey");
            });

            modelBuilder.Entity<PrecipitationParsing>(entity =>
            {
                entity.ToTable("precipitation_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstFiveMin).HasColumnName("first_five_min");

                entity.Property(e => e.SecondFiveMin).HasColumnName("second_five_min");

                entity.Property(e => e.Sum).HasColumnName("sum");
            });

            modelBuilder.Entity<RadiationMetaData>(entity =>
            {
                entity.ToTable("radiation_meta_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.InputTable)
                    .HasColumnName("input_table")
                    .HasMaxLength(50);

                entity.Property(e => e.LocalisedName)
                    .HasColumnName("localised_name")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SensorHeight).HasColumnName("sensor_height");

                entity.Property(e => e.TargetTableName)
                    .HasColumnName("target_table_name")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.RadiationMetaData)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("radiation_meta_data_fk_station_id_fkey");
            });

            modelBuilder.Entity<RadiationParsing>(entity =>
            {
                entity.ToTable("radiation_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diffuse).HasColumnName("diffuse");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Global).HasColumnName("global");

                entity.Property(e => e.SunDuration).HasColumnName("sun_duration");

                entity.Property(e => e.Uvb).HasColumnName("uvb");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.RadiationParsing)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("radiation_parsing_fk_station_id_fkey");
            });

            modelBuilder.Entity<Seatemperature>(entity =>
            {
                entity.ToTable("seatemperature");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasColumnType("numeric");

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasColumnType("numeric");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.Seatemperature)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("seatemperature_fk_station_id_fkey");
            });

            modelBuilder.Entity<SeatemperatureParsing>(entity =>
            {
                entity.ToTable("seatemperature_parsing");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Avg).HasColumnName("avg");

                entity.Property(e => e.Current).HasColumnName("current");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.StartName)
                    .HasColumnName("start_name")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.SeatemperatureParsing)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("seatemperature_parsing_fk_station_id_fkey");
            });

            modelBuilder.Entity<SensorElevation>(entity =>
            {
                entity.ToTable("sensor_elevation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AirTemp2m).HasColumnName("air_temp_2m");

                entity.Property(e => e.AirTemp5cm).HasColumnName("air_temp_5cm");

                entity.Property(e => e.AtmPressure).HasColumnName("atm_pressure");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.GenericElevation).HasColumnName("generic_elevation");

                entity.Property(e => e.GeoTemp10cm).HasColumnName("geo_temp_10cm");

                entity.Property(e => e.GeoTemp20cm).HasColumnName("geo_temp20cm");

                entity.Property(e => e.GeoTemp5cm).HasColumnName("geo_temp_5cm");

                entity.Property(e => e.WindLvl1).HasColumnName("wind_lvl1");

                entity.Property(e => e.WindLvl2).HasColumnName("wind_lvl2");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.SensorElevation)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sensor_elevation_fk_station_id_fkey");
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.ToTable("station");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdditionalDescription)
                    .HasColumnName("additional_description")
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ContactPerson)
                    .HasColumnName("contact_person")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.County)
                    .HasColumnName("county")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasColumnType("numeric");

                entity.Property(e => e.Lon)
                    .HasColumnName("lon")
                    .HasColumnType("numeric");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.ShortName)
                    .HasColumnName("short_name")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.StreetAddress)
                    .HasColumnName("street_address")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<SunDuration>(entity =>
            {
                entity.ToTable("sun_duration");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Sum).HasColumnName("sum");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.SunDuration)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sun_duration_fk_station_id_fkey");
            });

            modelBuilder.Entity<Temperature>(entity =>
            {
                entity.ToTable("temperature");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasColumnType("numeric");

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasColumnType("numeric");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Max)
                    .HasColumnName("max")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxTime)
                    .HasColumnName("max_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Min)
                    .HasColumnName("min")
                    .HasColumnType("numeric");

                entity.Property(e => e.MinTime)
                    .HasColumnName("min_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.Temperature)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("temperature_fk_station_id_fkey");
            });

            modelBuilder.Entity<TemperatureMetaData>(entity =>
            {
                entity.ToTable("temperature_meta_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.LocalisedName)
                    .HasColumnName("localised_name")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SeaTempPrefix)
                    .HasColumnName("sea_temp_prefix")
                    .HasMaxLength(3);

                entity.Property(e => e.SensorHeight)
                    .HasColumnName("sensor_height")
                    .HasColumnType("numeric");

                entity.Property(e => e.TargetTableName)
                    .HasColumnName("target_table_name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.TemperatureMetaData)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("temperature_meta_data_fk_station_id_fkey");
            });

            modelBuilder.Entity<TemperatureParsing>(entity =>
            {
                entity.ToTable("temperature_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avg)
                    .IsRequired()
                    .HasColumnName("avg");

                entity.Property(e => e.Current)
                    .IsRequired()
                    .HasColumnName("current");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("'.TN1'::bpchar");

                entity.Property(e => e.Max)
                    .IsRequired()
                    .HasColumnName("max");

                entity.Property(e => e.MaxTime)
                    .IsRequired()
                    .HasColumnName("max_time");

                entity.Property(e => e.Min)
                    .IsRequired()
                    .HasColumnName("min");

                entity.Property(e => e.MinTime)
                    .IsRequired()
                    .HasColumnName("min_time");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("character varying");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role")
                    .HasColumnType("character varying");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Uvb>(entity =>
            {
                entity.ToTable("uvb");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("numeric");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.Uvb)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("uvb_fk_station_id_fkey");
            });

            modelBuilder.Entity<Wind>(entity =>
            {
                entity.ToTable("wind");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvgDirection).HasColumnName("avg_direction");

                entity.Property(e => e.AvgSpeed)
                    .HasColumnName("avg_speed")
                    .HasColumnType("numeric");

                entity.Property(e => e.CurrentDirection).HasColumnName("current_direction");

                entity.Property(e => e.CurrentSpeed)
                    .HasColumnName("current_speed")
                    .HasColumnType("numeric");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.MaxDirection).HasColumnName("max_direction");

                entity.Property(e => e.MaxSpeed)
                    .HasColumnName("max_speed")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxSpeedTime)
                    .HasColumnName("max_speed_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.Wind)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Wind_FK_station_id_fkey");
            });

            modelBuilder.Entity<WindLvl2>(entity =>
            {
                entity.ToTable("wind_lvl2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvgDirection).HasColumnName("avg_direction");

                entity.Property(e => e.AvgSpeed)
                    .HasColumnName("avg_speed")
                    .HasColumnType("numeric");

                entity.Property(e => e.CurrentDirection).HasColumnName("current_direction");

                entity.Property(e => e.CurrentSpeed)
                    .HasColumnName("current_speed")
                    .HasColumnType("numeric");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.MaxDirection).HasColumnName("max_direction");

                entity.Property(e => e.MaxSpeed)
                    .HasColumnName("max_speed")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxSpeedTime)
                    .HasColumnName("max_speed_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.WindLvl2)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("wind_lvl2_fk_station_id_fkey");
            });

            modelBuilder.Entity<WindLvl2Parsing>(entity =>
            {
                entity.ToTable("wind_lvl2_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvgDirection)
                    .IsRequired()
                    .HasColumnName("avg_direction")
                    .HasDefaultValueSql("'{14,3}'::integer[]");

                entity.Property(e => e.AvgSpeed)
                    .IsRequired()
                    .HasColumnName("avg_speed");

                entity.Property(e => e.CurrentDirection)
                    .IsRequired()
                    .HasColumnName("current_direction")
                    .HasDefaultValueSql("'{32,3}'::integer[]");

                entity.Property(e => e.CurrentSpeed)
                    .IsRequired()
                    .HasColumnName("current_speed")
                    .HasDefaultValueSql("'{28,4}'::integer[]");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("'.VJ1'::bpchar");

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.MaxDirection)
                    .IsRequired()
                    .HasColumnName("max_direction")
                    .HasDefaultValueSql("'{32,3}'::integer[]");

                entity.Property(e => e.MaxSpeed)
                    .IsRequired()
                    .HasColumnName("max_speed");

                entity.Property(e => e.MaxSpeedTime)
                    .IsRequired()
                    .HasColumnName("max_speed_time")
                    .HasDefaultValueSql("'{24,4}'::integer[]");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.WindLvl2Parsing)
                    .HasForeignKey(d => d.FkStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("wind_lvl2_parsing_fk_station_id_fkey");
            });

            modelBuilder.Entity<WindMetaData>(entity =>
            {
                entity.ToTable("wind_meta_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FkStationId).HasColumnName("fk_station_id");

                entity.Property(e => e.LocalisedName)
                    .HasColumnName("localised_name")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SensorHeight).HasColumnName("sensor_height");

                entity.Property(e => e.TargetTableName)
                    .HasColumnName("target_table_name")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.FkStation)
                    .WithMany(p => p.WindMetaData)
                    .HasForeignKey(d => d.FkStationId)
                    .HasConstraintName("wind_meta_data_fk_station_id_fkey");
            });

            modelBuilder.Entity<WindParsing>(entity =>
            {
                entity.ToTable("wind_parsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvgDirection)
                    .IsRequired()
                    .HasColumnName("avg_direction")
                    .HasDefaultValueSql("'{14,3}'::integer[]");

                entity.Property(e => e.AvgSpeed)
                    .IsRequired()
                    .HasColumnName("avg_speed");

                entity.Property(e => e.CurrentDirection)
                    .IsRequired()
                    .HasColumnName("current_direction")
                    .HasDefaultValueSql("'{32,3}'::integer[]");

                entity.Property(e => e.CurrentSpeed)
                    .IsRequired()
                    .HasColumnName("current_speed")
                    .HasDefaultValueSql("'{28,4}'::integer[]");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("'.VJ1'::bpchar");

                entity.Property(e => e.MaxDirection)
                    .IsRequired()
                    .HasColumnName("max_direction")
                    .HasDefaultValueSql("'{32,3}'::integer[]");

                entity.Property(e => e.MaxSpeed)
                    .IsRequired()
                    .HasColumnName("max_speed");

                entity.Property(e => e.MaxSpeedTime)
                    .IsRequired()
                    .HasColumnName("max_speed_time")
                    .HasDefaultValueSql("'{24,4}'::integer[]");
            });

            modelBuilder.HasSequence("air_temp_5cm_id_seq");

            modelBuilder.HasSequence("air_temp_5cm_parsing_id_seq").HasMax(32567);

            modelBuilder.HasSequence("geo_humidity_id_seq");

            modelBuilder.HasSequence("geo_humidity_parsing_id_seq").HasMax(32767);

            modelBuilder.HasSequence("geo_temp_10cm_id_seq");

            modelBuilder.HasSequence("geo_temp_10cm_parsing_id_seq").HasMax(32567);

            modelBuilder.HasSequence("geo_temp_20cm_id_seq");

            modelBuilder.HasSequence("geo_temp_20cm_parsing_id_seq").HasMax(32567);

            modelBuilder.HasSequence("geo_temp_5cm_id_seq");

            modelBuilder.HasSequence("geo_temp_5cm_parsing_id_seq").HasMax(32567);

            modelBuilder.HasSequence("seatemperature_id_seq");

            modelBuilder.HasSequence("station_id_seq")
                .StartsAt(78)
                .HasMax(32000);

            modelBuilder.HasSequence("wind_lvl2_id_seq");

            modelBuilder.HasSequence("wind_lvl2_parsing_id_seq").HasMax(32767);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
