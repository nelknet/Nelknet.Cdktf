using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsOutputReference), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDashboardDashboardPublishOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDashboardDashboardPublishOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightDashboardDashboardPublishOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDashboardDashboardPublishOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdHocFilteringOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsAdHocFilteringOption\"}}]")]
        public virtual void PutAdHocFilteringOption(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsAdHocFilteringOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsAdHocFilteringOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataPointDrillUpDownOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointDrillUpDownOption\"}}]")]
        public virtual void PutDataPointDrillUpDownOption(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointDrillUpDownOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointDrillUpDownOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataPointMenuLabelOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointMenuLabelOption\"}}]")]
        public virtual void PutDataPointMenuLabelOption(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointMenuLabelOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointMenuLabelOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataPointTooltipOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointTooltipOption\"}}]")]
        public virtual void PutDataPointTooltipOption(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointTooltipOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointTooltipOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExportToCsvOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportToCsvOption\"}}]")]
        public virtual void PutExportToCsvOption(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportToCsvOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportToCsvOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExportWithHiddenFieldsOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportWithHiddenFieldsOption\"}}]")]
        public virtual void PutExportWithHiddenFieldsOption(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportWithHiddenFieldsOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportWithHiddenFieldsOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSheetControlsOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetControlsOption\"}}]")]
        public virtual void PutSheetControlsOption(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetControlsOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetControlsOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSheetLayoutElementMaximizationOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetLayoutElementMaximizationOption\"}}]")]
        public virtual void PutSheetLayoutElementMaximizationOption(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetLayoutElementMaximizationOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetLayoutElementMaximizationOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVisualAxisSortOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualAxisSortOption\"}}]")]
        public virtual void PutVisualAxisSortOption(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualAxisSortOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualAxisSortOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVisualMenuOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualMenuOption\"}}]")]
        public virtual void PutVisualMenuOption(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualMenuOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualMenuOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdHocFilteringOption")]
        public virtual void ResetAdHocFilteringOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataPointDrillUpDownOption")]
        public virtual void ResetDataPointDrillUpDownOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataPointMenuLabelOption")]
        public virtual void ResetDataPointMenuLabelOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataPointTooltipOption")]
        public virtual void ResetDataPointTooltipOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportToCsvOption")]
        public virtual void ResetExportToCsvOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportWithHiddenFieldsOption")]
        public virtual void ResetExportWithHiddenFieldsOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSheetControlsOption")]
        public virtual void ResetSheetControlsOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSheetLayoutElementMaximizationOption")]
        public virtual void ResetSheetLayoutElementMaximizationOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVisualAxisSortOption")]
        public virtual void ResetVisualAxisSortOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVisualMenuOption")]
        public virtual void ResetVisualMenuOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "adHocFilteringOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsAdHocFilteringOptionOutputReference\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsAdHocFilteringOptionOutputReference AdHocFilteringOption
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsAdHocFilteringOptionOutputReference>()!;
        }

        [JsiiProperty(name: "dataPointDrillUpDownOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointDrillUpDownOptionOutputReference\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointDrillUpDownOptionOutputReference DataPointDrillUpDownOption
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointDrillUpDownOptionOutputReference>()!;
        }

        [JsiiProperty(name: "dataPointMenuLabelOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointMenuLabelOptionOutputReference\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointMenuLabelOptionOutputReference DataPointMenuLabelOption
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointMenuLabelOptionOutputReference>()!;
        }

        [JsiiProperty(name: "dataPointTooltipOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointTooltipOptionOutputReference\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointTooltipOptionOutputReference DataPointTooltipOption
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointTooltipOptionOutputReference>()!;
        }

        [JsiiProperty(name: "exportToCsvOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportToCsvOptionOutputReference\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportToCsvOptionOutputReference ExportToCsvOption
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportToCsvOptionOutputReference>()!;
        }

        [JsiiProperty(name: "exportWithHiddenFieldsOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportWithHiddenFieldsOptionOutputReference\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportWithHiddenFieldsOptionOutputReference ExportWithHiddenFieldsOption
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportWithHiddenFieldsOptionOutputReference>()!;
        }

        [JsiiProperty(name: "sheetControlsOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetControlsOptionOutputReference\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetControlsOptionOutputReference SheetControlsOption
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetControlsOptionOutputReference>()!;
        }

        [JsiiProperty(name: "sheetLayoutElementMaximizationOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetLayoutElementMaximizationOptionOutputReference\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetLayoutElementMaximizationOptionOutputReference SheetLayoutElementMaximizationOption
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetLayoutElementMaximizationOptionOutputReference>()!;
        }

        [JsiiProperty(name: "visualAxisSortOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualAxisSortOptionOutputReference\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualAxisSortOptionOutputReference VisualAxisSortOption
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualAxisSortOptionOutputReference>()!;
        }

        [JsiiProperty(name: "visualMenuOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualMenuOptionOutputReference\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualMenuOptionOutputReference VisualMenuOption
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualMenuOptionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adHocFilteringOptionInput", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsAdHocFilteringOption\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsAdHocFilteringOption? AdHocFilteringOptionInput
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsAdHocFilteringOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataPointDrillUpDownOptionInput", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointDrillUpDownOption\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointDrillUpDownOption? DataPointDrillUpDownOptionInput
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointDrillUpDownOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataPointMenuLabelOptionInput", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointMenuLabelOption\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointMenuLabelOption? DataPointMenuLabelOptionInput
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointMenuLabelOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataPointTooltipOptionInput", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointTooltipOption\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointTooltipOption? DataPointTooltipOptionInput
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointTooltipOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportToCsvOptionInput", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportToCsvOption\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportToCsvOption? ExportToCsvOptionInput
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportToCsvOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportWithHiddenFieldsOptionInput", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportWithHiddenFieldsOption\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportWithHiddenFieldsOption? ExportWithHiddenFieldsOptionInput
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportWithHiddenFieldsOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sheetControlsOptionInput", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetControlsOption\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetControlsOption? SheetControlsOptionInput
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetControlsOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sheetLayoutElementMaximizationOptionInput", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetLayoutElementMaximizationOption\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetLayoutElementMaximizationOption? SheetLayoutElementMaximizationOptionInput
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetLayoutElementMaximizationOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "visualAxisSortOptionInput", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualAxisSortOption\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualAxisSortOption? VisualAxisSortOptionInput
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualAxisSortOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "visualMenuOptionInput", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualMenuOption\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualMenuOption? VisualMenuOptionInput
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualMenuOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptions\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptions? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
