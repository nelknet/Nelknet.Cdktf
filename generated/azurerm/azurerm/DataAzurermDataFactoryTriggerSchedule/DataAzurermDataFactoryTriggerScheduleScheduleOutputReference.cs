using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataFactoryTriggerSchedule
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerScheduleScheduleOutputReference), fullyQualifiedName: "azurerm.dataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerScheduleScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermDataFactoryTriggerScheduleScheduleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermDataFactoryTriggerScheduleScheduleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermDataFactoryTriggerScheduleScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermDataFactoryTriggerScheduleScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "daysOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] DaysOfMonth
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DaysOfWeek
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "hours", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] Hours
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "minutes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] Minutes
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "monthly", typeJson: "{\"fqn\":\"azurerm.dataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerScheduleScheduleMonthlyList\"}")]
        public virtual azurerm.DataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerScheduleScheduleMonthlyList Monthly
        {
            get => GetInstanceProperty<azurerm.DataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerScheduleScheduleMonthlyList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerScheduleSchedule\"}", isOptional: true)]
        public virtual azurerm.DataAzurermDataFactoryTriggerSchedule.IDataAzurermDataFactoryTriggerScheduleSchedule? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermDataFactoryTriggerSchedule.IDataAzurermDataFactoryTriggerScheduleSchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
