using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsQuicksightDataSet
{
    [JsiiClass(nativeType: typeof(aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapOutputReference), fullyQualifiedName: "aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsQuicksightDataSetPhysicalTableMapOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsQuicksightDataSetPhysicalTableMapOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsQuicksightDataSetPhysicalTableMapOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsQuicksightDataSetPhysicalTableMapOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "customSql", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapCustomSqlList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapCustomSqlList CustomSql
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapCustomSqlList>()!;
        }

        [JsiiProperty(name: "physicalTableMapId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhysicalTableMapId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relationalTable", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapRelationalTableList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapRelationalTableList RelationalTable
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapRelationalTableList>()!;
        }

        [JsiiProperty(name: "s3Source", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapS3SourceList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapS3SourceList S3Source
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapS3SourceList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMap\"}", isOptional: true)]
        public virtual aws.DataAwsQuicksightDataSet.IDataAwsQuicksightDataSetPhysicalTableMap? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.IDataAwsQuicksightDataSetPhysicalTableMap?>();
            set => SetInstanceProperty(value);
        }
    }
}
