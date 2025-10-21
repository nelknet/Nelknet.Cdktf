using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapStorageVirtualMachine
{
    [JsiiClass(nativeType: typeof(aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsOutputReference), fullyQualifiedName: "aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FsxOntapStorageVirtualMachineEndpointsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public FsxOntapStorageVirtualMachineEndpointsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected FsxOntapStorageVirtualMachineEndpointsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapStorageVirtualMachineEndpointsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "iscsi", typeJson: "{\"fqn\":\"aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsIscsiList\"}")]
        public virtual aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsIscsiList Iscsi
        {
            get => GetInstanceProperty<aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsIscsiList>()!;
        }

        [JsiiProperty(name: "management", typeJson: "{\"fqn\":\"aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsManagementList\"}")]
        public virtual aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsManagementList Management
        {
            get => GetInstanceProperty<aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsManagementList>()!;
        }

        [JsiiProperty(name: "nfs", typeJson: "{\"fqn\":\"aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsNfsList\"}")]
        public virtual aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsNfsList Nfs
        {
            get => GetInstanceProperty<aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsNfsList>()!;
        }

        [JsiiProperty(name: "smb", typeJson: "{\"fqn\":\"aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsSmbList\"}")]
        public virtual aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsSmbList Smb
        {
            get => GetInstanceProperty<aws.FsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpointsSmbList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsxOntapStorageVirtualMachine.FsxOntapStorageVirtualMachineEndpoints\"}", isOptional: true)]
        public virtual aws.FsxOntapStorageVirtualMachine.IFsxOntapStorageVirtualMachineEndpoints? InternalValue
        {
            get => GetInstanceProperty<aws.FsxOntapStorageVirtualMachine.IFsxOntapStorageVirtualMachineEndpoints?>();
            set => SetInstanceProperty(value);
        }
    }
}
