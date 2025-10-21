using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRoute53Records
{
    [JsiiClass(nativeType: typeof(aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationCoordinatesOutputReference), fullyQualifiedName: "aws.dataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationCoordinatesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationCoordinatesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationCoordinatesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationCoordinatesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationCoordinatesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Latitude
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Longitude
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationCoordinates\"}", isOptional: true)]
        public virtual aws.DataAwsRoute53Records.IDataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationCoordinates? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsRoute53Records.IDataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationCoordinates?>();
            set => SetInstanceProperty(value);
        }
    }
}
