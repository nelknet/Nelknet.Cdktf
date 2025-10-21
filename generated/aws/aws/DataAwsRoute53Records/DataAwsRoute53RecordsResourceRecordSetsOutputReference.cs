using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRoute53Records
{
    [JsiiClass(nativeType: typeof(aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsOutputReference), fullyQualifiedName: "aws.dataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsRoute53RecordsResourceRecordSetsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsRoute53RecordsResourceRecordSetsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsRoute53RecordsResourceRecordSetsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsRoute53RecordsResourceRecordSetsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aliasTarget", typeJson: "{\"fqn\":\"aws.dataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsAliasTargetOutputReference\"}")]
        public virtual aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsAliasTargetOutputReference AliasTarget
        {
            get => GetInstanceProperty<aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsAliasTargetOutputReference>()!;
        }

        [JsiiProperty(name: "cidrRoutingConfig", typeJson: "{\"fqn\":\"aws.dataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsCidrRoutingConfigOutputReference\"}")]
        public virtual aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsCidrRoutingConfigOutputReference CidrRoutingConfig
        {
            get => GetInstanceProperty<aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsCidrRoutingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "failover", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Failover
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "geolocation", typeJson: "{\"fqn\":\"aws.dataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsGeolocationOutputReference\"}")]
        public virtual aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsGeolocationOutputReference Geolocation
        {
            get => GetInstanceProperty<aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsGeolocationOutputReference>()!;
        }

        [JsiiProperty(name: "geoproximityLocation", typeJson: "{\"fqn\":\"aws.dataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationOutputReference\"}")]
        public virtual aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationOutputReference GeoproximityLocation
        {
            get => GetInstanceProperty<aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsGeoproximityLocationOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "multiValueAnswer", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable MultiValueAnswer
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceRecords", typeJson: "{\"fqn\":\"aws.dataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsResourceRecordsList\"}")]
        public virtual aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsResourceRecordsList ResourceRecords
        {
            get => GetInstanceProperty<aws.DataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSetsResourceRecordsList>()!;
        }

        [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trafficPolicyInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficPolicyInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ttl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Weight
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsRoute53Records.DataAwsRoute53RecordsResourceRecordSets\"}", isOptional: true)]
        public virtual aws.DataAwsRoute53Records.IDataAwsRoute53RecordsResourceRecordSets? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsRoute53Records.IDataAwsRoute53RecordsResourceRecordSets?>();
            set => SetInstanceProperty(value);
        }
    }
}
