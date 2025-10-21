using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetColumnGroups), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetColumnGroups")]
    public interface IQuicksightDataSetColumnGroups
    {
        /// <summary>geo_spatial_column_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#geo_spatial_column_group QuicksightDataSet#geo_spatial_column_group}
        /// </remarks>
        [JsiiProperty(name: "geoSpatialColumnGroup", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetColumnGroupsGeoSpatialColumnGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetColumnGroupsGeoSpatialColumnGroup? GeoSpatialColumnGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetColumnGroups), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetColumnGroups")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetColumnGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>geo_spatial_column_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#geo_spatial_column_group QuicksightDataSet#geo_spatial_column_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geoSpatialColumnGroup", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetColumnGroupsGeoSpatialColumnGroup\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetColumnGroupsGeoSpatialColumnGroup? GeoSpatialColumnGroup
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetColumnGroupsGeoSpatialColumnGroup?>();
            }
        }
    }
}
