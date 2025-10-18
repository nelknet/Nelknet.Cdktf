using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudServerTypes
{
    [JsiiClass(nativeType: typeof(hcloud.DataHcloudServerTypes.DataHcloudServerTypesServerTypesOutputReference), fullyQualifiedName: "hcloud.dataHcloudServerTypes.DataHcloudServerTypesServerTypesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataHcloudServerTypesServerTypesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataHcloudServerTypesServerTypesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataHcloudServerTypesServerTypesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataHcloudServerTypesServerTypesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cores", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Cores
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpuType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpuType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deprecationAnnounced", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeprecationAnnounced
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disk", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Disk
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "includedTraffic", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IncludedTraffic
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isDeprecated", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IsDeprecated
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "locations", typeJson: "{\"fqn\":\"hcloud.dataHcloudServerTypes.DataHcloudServerTypesServerTypesLocationsList\"}")]
        public virtual hcloud.DataHcloudServerTypes.DataHcloudServerTypesServerTypesLocationsList Locations
        {
            get => GetInstanceProperty<hcloud.DataHcloudServerTypes.DataHcloudServerTypesServerTypesLocationsList>()!;
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Memory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unavailableAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnavailableAfter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"hcloud.dataHcloudServerTypes.DataHcloudServerTypesServerTypes\"}", isOptional: true)]
        public virtual hcloud.DataHcloudServerTypes.IDataHcloudServerTypesServerTypes? InternalValue
        {
            get => GetInstanceProperty<hcloud.DataHcloudServerTypes.IDataHcloudServerTypesServerTypes?>();
            set => SetInstanceProperty(value);
        }
    }
}
