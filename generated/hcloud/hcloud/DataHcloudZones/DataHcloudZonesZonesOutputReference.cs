using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudZones
{
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudZones.DataHcloudZonesZonesOutputReference), fullyQualifiedName: "hcloud.dataHcloudZones.DataHcloudZonesZonesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataHcloudZonesZonesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataHcloudZonesZonesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataHcloudZonesZonesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudZonesZonesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authoritativeNameservers", typeJson: "{\"fqn\":\"hcloud.dataHcloudZones.DataHcloudZonesZonesAuthoritativeNameserversOutputReference\"}")]
        public virtual hcloud.DataHcloudZones.DataHcloudZonesZonesAuthoritativeNameserversOutputReference AuthoritativeNameservers
        {
            get => GetInstanceProperty<hcloud.DataHcloudZones.DataHcloudZonesZonesAuthoritativeNameserversOutputReference>()!;
        }

        [JsiiProperty(name: "deleteProtection", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DeleteProtection
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Labels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryNameservers", typeJson: "{\"fqn\":\"hcloud.dataHcloudZones.DataHcloudZonesZonesPrimaryNameserversList\"}")]
        public virtual hcloud.DataHcloudZones.DataHcloudZonesZonesPrimaryNameserversList PrimaryNameservers
        {
            get => GetInstanceProperty<hcloud.DataHcloudZones.DataHcloudZonesZonesPrimaryNameserversList>()!;
        }

        [JsiiProperty(name: "registrar", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Registrar
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ttl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"hcloud.dataHcloudZones.DataHcloudZonesZones\"}", isOptional: true)]
        public virtual hcloud.DataHcloudZones.IDataHcloudZonesZones? InternalValue
        {
            get => GetInstanceProperty<hcloud.DataHcloudZones.IDataHcloudZonesZones?>();
            set => SetInstanceProperty(value);
        }
    }
}
