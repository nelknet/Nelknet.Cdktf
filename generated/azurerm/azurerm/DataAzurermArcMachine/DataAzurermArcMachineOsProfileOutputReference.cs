using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermArcMachine
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermArcMachine.DataAzurermArcMachineOsProfileOutputReference), fullyQualifiedName: "azurerm.dataAzurermArcMachine.DataAzurermArcMachineOsProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermArcMachineOsProfileOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermArcMachineOsProfileOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermArcMachineOsProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermArcMachineOsProfileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "computerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "linux", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineOsProfileLinuxList\"}")]
        public virtual azurerm.DataAzurermArcMachine.DataAzurermArcMachineOsProfileLinuxList Linux
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.DataAzurermArcMachineOsProfileLinuxList>()!;
        }

        [JsiiProperty(name: "windows", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineOsProfileWindowsList\"}")]
        public virtual azurerm.DataAzurermArcMachine.DataAzurermArcMachineOsProfileWindowsList Windows
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.DataAzurermArcMachineOsProfileWindowsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermArcMachine.DataAzurermArcMachineOsProfile\"}", isOptional: true)]
        public virtual azurerm.DataAzurermArcMachine.IDataAzurermArcMachineOsProfile? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermArcMachine.IDataAzurermArcMachineOsProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
