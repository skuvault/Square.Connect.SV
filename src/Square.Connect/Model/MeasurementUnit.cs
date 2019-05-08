/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// Represents a unit of measurement to use with a quantity, such as ounces or inches. Exactly one of the following fields are required: &#x60;custom_unit&#x60;, &#x60;area_unit&#x60;, &#x60;length_unit&#x60;, &#x60;volume_unit&#x60;, and &#x60;weight_unit&#x60;.  The &#x60;family&#x60; field describes the type of measurement. For example, ounces are in the weight family.
    /// </summary>
    [DataContract]
    public partial class MeasurementUnit :  IEquatable<MeasurementUnit>, IValidatableObject
    {
        /// <summary>
        /// Represents a standard area unit. See [MeasurementUnitArea](#type-measurementunitarea) for possible values
        /// </summary>
        /// <value>Represents a standard area unit. See [MeasurementUnitArea](#type-measurementunitarea) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AreaUnitEnum
        {
            
            /// <summary>
            /// Enum IMPERIALACRE for "IMPERIAL_ACRE"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_ACRE")]
            IMPERIALACRE,
            
            /// <summary>
            /// Enum IMPERIALSQUAREINCH for "IMPERIAL_SQUARE_INCH"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_SQUARE_INCH")]
            IMPERIALSQUAREINCH,
            
            /// <summary>
            /// Enum IMPERIALSQUAREFOOT for "IMPERIAL_SQUARE_FOOT"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_SQUARE_FOOT")]
            IMPERIALSQUAREFOOT,
            
            /// <summary>
            /// Enum IMPERIALSQUAREYARD for "IMPERIAL_SQUARE_YARD"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_SQUARE_YARD")]
            IMPERIALSQUAREYARD,
            
            /// <summary>
            /// Enum IMPERIALSQUAREMILE for "IMPERIAL_SQUARE_MILE"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_SQUARE_MILE")]
            IMPERIALSQUAREMILE,
            
            /// <summary>
            /// Enum METRICSQUARECENTIMETER for "METRIC_SQUARE_CENTIMETER"
            /// </summary>
            [EnumMember(Value = "METRIC_SQUARE_CENTIMETER")]
            METRICSQUARECENTIMETER,
            
            /// <summary>
            /// Enum METRICSQUAREMETER for "METRIC_SQUARE_METER"
            /// </summary>
            [EnumMember(Value = "METRIC_SQUARE_METER")]
            METRICSQUAREMETER,
            
            /// <summary>
            /// Enum METRICSQUAREKILOMETER for "METRIC_SQUARE_KILOMETER"
            /// </summary>
            [EnumMember(Value = "METRIC_SQUARE_KILOMETER")]
            METRICSQUAREKILOMETER
        }

        /// <summary>
        /// Represents a standard length unit. See [MeasurementUnitLength](#type-measurementunitlength) for possible values
        /// </summary>
        /// <value>Represents a standard length unit. See [MeasurementUnitLength](#type-measurementunitlength) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LengthUnitEnum
        {
            
            /// <summary>
            /// Enum IMPERIALINCH for "IMPERIAL_INCH"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_INCH")]
            IMPERIALINCH,
            
            /// <summary>
            /// Enum IMPERIALFOOT for "IMPERIAL_FOOT"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_FOOT")]
            IMPERIALFOOT,
            
            /// <summary>
            /// Enum IMPERIALYARD for "IMPERIAL_YARD"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_YARD")]
            IMPERIALYARD,
            
            /// <summary>
            /// Enum IMPERIALMILE for "IMPERIAL_MILE"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_MILE")]
            IMPERIALMILE,
            
            /// <summary>
            /// Enum METRICMILLIMETER for "METRIC_MILLIMETER"
            /// </summary>
            [EnumMember(Value = "METRIC_MILLIMETER")]
            METRICMILLIMETER,
            
            /// <summary>
            /// Enum METRICCENTIMETER for "METRIC_CENTIMETER"
            /// </summary>
            [EnumMember(Value = "METRIC_CENTIMETER")]
            METRICCENTIMETER,
            
            /// <summary>
            /// Enum METRICMETER for "METRIC_METER"
            /// </summary>
            [EnumMember(Value = "METRIC_METER")]
            METRICMETER,
            
            /// <summary>
            /// Enum METRICKILOMETER for "METRIC_KILOMETER"
            /// </summary>
            [EnumMember(Value = "METRIC_KILOMETER")]
            METRICKILOMETER
        }

        /// <summary>
        /// Represents a standard volume unit. See [MeasurementUnitVolume](#type-measurementunitvolume) for possible values
        /// </summary>
        /// <value>Represents a standard volume unit. See [MeasurementUnitVolume](#type-measurementunitvolume) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VolumeUnitEnum
        {
            
            /// <summary>
            /// Enum GENERICFLUIDOUNCE for "GENERIC_FLUID_OUNCE"
            /// </summary>
            [EnumMember(Value = "GENERIC_FLUID_OUNCE")]
            GENERICFLUIDOUNCE,
            
            /// <summary>
            /// Enum GENERICSHOT for "GENERIC_SHOT"
            /// </summary>
            [EnumMember(Value = "GENERIC_SHOT")]
            GENERICSHOT,
            
            /// <summary>
            /// Enum GENERICCUP for "GENERIC_CUP"
            /// </summary>
            [EnumMember(Value = "GENERIC_CUP")]
            GENERICCUP,
            
            /// <summary>
            /// Enum GENERICPINT for "GENERIC_PINT"
            /// </summary>
            [EnumMember(Value = "GENERIC_PINT")]
            GENERICPINT,
            
            /// <summary>
            /// Enum GENERICQUART for "GENERIC_QUART"
            /// </summary>
            [EnumMember(Value = "GENERIC_QUART")]
            GENERICQUART,
            
            /// <summary>
            /// Enum GENERICGALLON for "GENERIC_GALLON"
            /// </summary>
            [EnumMember(Value = "GENERIC_GALLON")]
            GENERICGALLON,
            
            /// <summary>
            /// Enum IMPERIALCUBICINCH for "IMPERIAL_CUBIC_INCH"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_CUBIC_INCH")]
            IMPERIALCUBICINCH,
            
            /// <summary>
            /// Enum IMPERIALCUBICFOOT for "IMPERIAL_CUBIC_FOOT"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_CUBIC_FOOT")]
            IMPERIALCUBICFOOT,
            
            /// <summary>
            /// Enum IMPERIALCUBICYARD for "IMPERIAL_CUBIC_YARD"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_CUBIC_YARD")]
            IMPERIALCUBICYARD,
            
            /// <summary>
            /// Enum METRICMILLILITER for "METRIC_MILLILITER"
            /// </summary>
            [EnumMember(Value = "METRIC_MILLILITER")]
            METRICMILLILITER,
            
            /// <summary>
            /// Enum METRICLITER for "METRIC_LITER"
            /// </summary>
            [EnumMember(Value = "METRIC_LITER")]
            METRICLITER
        }

        /// <summary>
        /// Represents a standard unit of weight or mass. See [MeasurementUnitWeight](#type-measurementunitweight) for possible values
        /// </summary>
        /// <value>Represents a standard unit of weight or mass. See [MeasurementUnitWeight](#type-measurementunitweight) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WeightUnitEnum
        {
            
            /// <summary>
            /// Enum IMPERIALWEIGHTOUNCE for "IMPERIAL_WEIGHT_OUNCE"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_WEIGHT_OUNCE")]
            IMPERIALWEIGHTOUNCE,
            
            /// <summary>
            /// Enum IMPERIALPOUND for "IMPERIAL_POUND"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_POUND")]
            IMPERIALPOUND,
            
            /// <summary>
            /// Enum IMPERIALSTONE for "IMPERIAL_STONE"
            /// </summary>
            [EnumMember(Value = "IMPERIAL_STONE")]
            IMPERIALSTONE,
            
            /// <summary>
            /// Enum METRICMILLIGRAM for "METRIC_MILLIGRAM"
            /// </summary>
            [EnumMember(Value = "METRIC_MILLIGRAM")]
            METRICMILLIGRAM,
            
            /// <summary>
            /// Enum METRICGRAM for "METRIC_GRAM"
            /// </summary>
            [EnumMember(Value = "METRIC_GRAM")]
            METRICGRAM,
            
            /// <summary>
            /// Enum METRICKILOGRAM for "METRIC_KILOGRAM"
            /// </summary>
            [EnumMember(Value = "METRIC_KILOGRAM")]
            METRICKILOGRAM
        }

        /// <summary>
        /// Represents a standard area unit. See [MeasurementUnitArea](#type-measurementunitarea) for possible values
        /// </summary>
        /// <value>Represents a standard area unit. See [MeasurementUnitArea](#type-measurementunitarea) for possible values</value>
        [DataMember(Name="area_unit", EmitDefaultValue=false)]
        public AreaUnitEnum? AreaUnit { get; set; }
        /// <summary>
        /// Represents a standard length unit. See [MeasurementUnitLength](#type-measurementunitlength) for possible values
        /// </summary>
        /// <value>Represents a standard length unit. See [MeasurementUnitLength](#type-measurementunitlength) for possible values</value>
        [DataMember(Name="length_unit", EmitDefaultValue=false)]
        public LengthUnitEnum? LengthUnit { get; set; }
        /// <summary>
        /// Represents a standard volume unit. See [MeasurementUnitVolume](#type-measurementunitvolume) for possible values
        /// </summary>
        /// <value>Represents a standard volume unit. See [MeasurementUnitVolume](#type-measurementunitvolume) for possible values</value>
        [DataMember(Name="volume_unit", EmitDefaultValue=false)]
        public VolumeUnitEnum? VolumeUnit { get; set; }
        /// <summary>
        /// Represents a standard unit of weight or mass. See [MeasurementUnitWeight](#type-measurementunitweight) for possible values
        /// </summary>
        /// <value>Represents a standard unit of weight or mass. See [MeasurementUnitWeight](#type-measurementunitweight) for possible values</value>
        [DataMember(Name="weight_unit", EmitDefaultValue=false)]
        public WeightUnitEnum? WeightUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementUnit" /> class.
        /// </summary>
        /// <param name="CustomUnit">A custom unit of measurement defined by the seller using the Point of Sale app or ad-hoc as an order line item..</param>
        /// <param name="AreaUnit">Represents a standard area unit. See [MeasurementUnitArea](#type-measurementunitarea) for possible values.</param>
        /// <param name="LengthUnit">Represents a standard length unit. See [MeasurementUnitLength](#type-measurementunitlength) for possible values.</param>
        /// <param name="VolumeUnit">Represents a standard volume unit. See [MeasurementUnitVolume](#type-measurementunitvolume) for possible values.</param>
        /// <param name="WeightUnit">Represents a standard unit of weight or mass. See [MeasurementUnitWeight](#type-measurementunitweight) for possible values.</param>
        public MeasurementUnit(MeasurementUnitCustom CustomUnit = default(MeasurementUnitCustom), AreaUnitEnum? AreaUnit = default(AreaUnitEnum?), LengthUnitEnum? LengthUnit = default(LengthUnitEnum?), VolumeUnitEnum? VolumeUnit = default(VolumeUnitEnum?), WeightUnitEnum? WeightUnit = default(WeightUnitEnum?))
        {
            this.CustomUnit = CustomUnit;
            this.AreaUnit = AreaUnit;
            this.LengthUnit = LengthUnit;
            this.VolumeUnit = VolumeUnit;
            this.WeightUnit = WeightUnit;
        }
        
        /// <summary>
        /// A custom unit of measurement defined by the seller using the Point of Sale app or ad-hoc as an order line item.
        /// </summary>
        /// <value>A custom unit of measurement defined by the seller using the Point of Sale app or ad-hoc as an order line item.</value>
        [DataMember(Name="custom_unit", EmitDefaultValue=false)]
        public MeasurementUnitCustom CustomUnit { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeasurementUnit {\n");
            sb.Append("  CustomUnit: ").Append(CustomUnit).Append("\n");
            sb.Append("  AreaUnit: ").Append(AreaUnit).Append("\n");
            sb.Append("  LengthUnit: ").Append(LengthUnit).Append("\n");
            sb.Append("  VolumeUnit: ").Append(VolumeUnit).Append("\n");
            sb.Append("  WeightUnit: ").Append(WeightUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MeasurementUnit);
        }

        /// <summary>
        /// Returns true if MeasurementUnit instances are equal
        /// </summary>
        /// <param name="other">Instance of MeasurementUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeasurementUnit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomUnit == other.CustomUnit ||
                    this.CustomUnit != null &&
                    this.CustomUnit.Equals(other.CustomUnit)
                ) && 
                (
                    this.AreaUnit == other.AreaUnit ||
                    this.AreaUnit != null &&
                    this.AreaUnit.Equals(other.AreaUnit)
                ) && 
                (
                    this.LengthUnit == other.LengthUnit ||
                    this.LengthUnit != null &&
                    this.LengthUnit.Equals(other.LengthUnit)
                ) && 
                (
                    this.VolumeUnit == other.VolumeUnit ||
                    this.VolumeUnit != null &&
                    this.VolumeUnit.Equals(other.VolumeUnit)
                ) && 
                (
                    this.WeightUnit == other.WeightUnit ||
                    this.WeightUnit != null &&
                    this.WeightUnit.Equals(other.WeightUnit)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CustomUnit != null)
                    hash = hash * 59 + this.CustomUnit.GetHashCode();
                if (this.AreaUnit != null)
                    hash = hash * 59 + this.AreaUnit.GetHashCode();
                if (this.LengthUnit != null)
                    hash = hash * 59 + this.LengthUnit.GetHashCode();
                if (this.VolumeUnit != null)
                    hash = hash * 59 + this.VolumeUnit.GetHashCode();
                if (this.WeightUnit != null)
                    hash = hash * 59 + this.WeightUnit.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
