using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class Station
    {
        public Station()
        {
            AirTemp5cm = new HashSet<AirTemp5cm>();
            AirTemp5cmParsing = new HashSet<AirTemp5cmParsing>();
            AtmPressureMetaData = new HashSet<AtmPressureMetaData>();
            AtmosphericPressure = new HashSet<AtmosphericPressure>();
            DiffuseRadiation = new HashSet<DiffuseRadiation>();
            GeoHumidity = new HashSet<GeoHumidity>();
            GeoHumidityParsing = new HashSet<GeoHumidityParsing>();
            GeoTemp10cm = new HashSet<GeoTemp10cm>();
            GeoTemp10cmParsing = new HashSet<GeoTemp10cmParsing>();
            GeoTemp20cm = new HashSet<GeoTemp20cm>();
            GeoTemp20cmParsing = new HashSet<GeoTemp20cmParsing>();
            GeoTemp5cm = new HashSet<GeoTemp5cm>();
            GeoTemp5cmParsing = new HashSet<GeoTemp5cmParsing>();
            GlobalRadiation = new HashSet<GlobalRadiation>();
            Humidity = new HashSet<Humidity>();
            HumidityMetaData = new HashSet<HumidityMetaData>();
            Precipitation = new HashSet<Precipitation>();
            PrecipitationMetaData = new HashSet<PrecipitationMetaData>();
            RadiationMetaData = new HashSet<RadiationMetaData>();
            RadiationParsing = new HashSet<RadiationParsing>();
            Seatemperature = new HashSet<Seatemperature>();
            SeatemperatureParsing = new HashSet<SeatemperatureParsing>();
            SensorElevation = new HashSet<SensorElevation>();
            SunDuration = new HashSet<SunDuration>();
            Temperature = new HashSet<Temperature>();
            TemperatureMetaData = new HashSet<TemperatureMetaData>();
            Uvb = new HashSet<Uvb>();
            Wind = new HashSet<Wind>();
            WindLvl2 = new HashSet<WindLvl2>();
            WindLvl2Parsing = new HashSet<WindLvl2Parsing>();
            WindMetaData = new HashSet<WindMetaData>();
        }

        public short Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Owner { get; set; }
        public int? Height { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lon { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string StreetAddress { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string AdditionalDescription { get; set; }
        public short? UserId { get; set; }

        public virtual ICollection<AirTemp5cm> AirTemp5cm { get; set; }
        public virtual ICollection<AirTemp5cmParsing> AirTemp5cmParsing { get; set; }
        public virtual ICollection<AtmPressureMetaData> AtmPressureMetaData { get; set; }
        public virtual ICollection<AtmosphericPressure> AtmosphericPressure { get; set; }
        public virtual ICollection<DiffuseRadiation> DiffuseRadiation { get; set; }
        public virtual ICollection<GeoHumidity> GeoHumidity { get; set; }
        public virtual ICollection<GeoHumidityParsing> GeoHumidityParsing { get; set; }
        public virtual ICollection<GeoTemp10cm> GeoTemp10cm { get; set; }
        public virtual ICollection<GeoTemp10cmParsing> GeoTemp10cmParsing { get; set; }
        public virtual ICollection<GeoTemp20cm> GeoTemp20cm { get; set; }
        public virtual ICollection<GeoTemp20cmParsing> GeoTemp20cmParsing { get; set; }
        public virtual ICollection<GeoTemp5cm> GeoTemp5cm { get; set; }
        public virtual ICollection<GeoTemp5cmParsing> GeoTemp5cmParsing { get; set; }
        public virtual ICollection<GlobalRadiation> GlobalRadiation { get; set; }
        public virtual ICollection<Humidity> Humidity { get; set; }
        public virtual ICollection<HumidityMetaData> HumidityMetaData { get; set; }
        public virtual ICollection<Precipitation> Precipitation { get; set; }
        public virtual ICollection<PrecipitationMetaData> PrecipitationMetaData { get; set; }
        public virtual ICollection<RadiationMetaData> RadiationMetaData { get; set; }
        public virtual ICollection<RadiationParsing> RadiationParsing { get; set; }
        public virtual ICollection<Seatemperature> Seatemperature { get; set; }
        public virtual ICollection<SeatemperatureParsing> SeatemperatureParsing { get; set; }
        public virtual ICollection<SensorElevation> SensorElevation { get; set; }
        public virtual ICollection<SunDuration> SunDuration { get; set; }
        public virtual ICollection<Temperature> Temperature { get; set; }
        public virtual ICollection<TemperatureMetaData> TemperatureMetaData { get; set; }
        public virtual ICollection<Uvb> Uvb { get; set; }
        public virtual ICollection<Wind> Wind { get; set; }
        public virtual ICollection<WindLvl2> WindLvl2 { get; set; }
        public virtual ICollection<WindLvl2Parsing> WindLvl2Parsing { get; set; }
        public virtual ICollection<WindMetaData> WindMetaData { get; set; }
    }
}
