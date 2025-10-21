using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetColumnGroups")]
    public class QuicksightDataSetColumnGroups : aws.QuicksightDataSet.IQuicksightDataSetColumnGroups
    {
        /// <summary>geo_spatial_column_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#geo_spatial_column_group QuicksightDataSet#geo_spatial_column_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geoSpatialColumnGroup", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetColumnGroupsGeoSpatialColumnGroup\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetColumnGroupsGeoSpatialColumnGroup? GeoSpatialColumnGroup
        {
            get;
            set;
        }
    }
}
