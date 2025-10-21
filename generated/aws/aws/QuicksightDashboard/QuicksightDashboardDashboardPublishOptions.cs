using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiByValue(fqn: "aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptions")]
    public class QuicksightDashboardDashboardPublishOptions : aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptions
    {
        /// <summary>ad_hoc_filtering_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#ad_hoc_filtering_option QuicksightDashboard#ad_hoc_filtering_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adHocFilteringOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsAdHocFilteringOption\"}", isOptional: true)]
        public aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsAdHocFilteringOption? AdHocFilteringOption
        {
            get;
            set;
        }

        /// <summary>data_point_drill_up_down_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_point_drill_up_down_option QuicksightDashboard#data_point_drill_up_down_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataPointDrillUpDownOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointDrillUpDownOption\"}", isOptional: true)]
        public aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointDrillUpDownOption? DataPointDrillUpDownOption
        {
            get;
            set;
        }

        /// <summary>data_point_menu_label_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_point_menu_label_option QuicksightDashboard#data_point_menu_label_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataPointMenuLabelOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointMenuLabelOption\"}", isOptional: true)]
        public aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointMenuLabelOption? DataPointMenuLabelOption
        {
            get;
            set;
        }

        /// <summary>data_point_tooltip_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_point_tooltip_option QuicksightDashboard#data_point_tooltip_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataPointTooltipOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsDataPointTooltipOption\"}", isOptional: true)]
        public aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsDataPointTooltipOption? DataPointTooltipOption
        {
            get;
            set;
        }

        /// <summary>export_to_csv_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#export_to_csv_option QuicksightDashboard#export_to_csv_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exportToCsvOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportToCsvOption\"}", isOptional: true)]
        public aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportToCsvOption? ExportToCsvOption
        {
            get;
            set;
        }

        /// <summary>export_with_hidden_fields_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#export_with_hidden_fields_option QuicksightDashboard#export_with_hidden_fields_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exportWithHiddenFieldsOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportWithHiddenFieldsOption\"}", isOptional: true)]
        public aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportWithHiddenFieldsOption? ExportWithHiddenFieldsOption
        {
            get;
            set;
        }

        /// <summary>sheet_controls_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#sheet_controls_option QuicksightDashboard#sheet_controls_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sheetControlsOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetControlsOption\"}", isOptional: true)]
        public aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetControlsOption? SheetControlsOption
        {
            get;
            set;
        }

        /// <summary>sheet_layout_element_maximization_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#sheet_layout_element_maximization_option QuicksightDashboard#sheet_layout_element_maximization_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sheetLayoutElementMaximizationOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetLayoutElementMaximizationOption\"}", isOptional: true)]
        public aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetLayoutElementMaximizationOption? SheetLayoutElementMaximizationOption
        {
            get;
            set;
        }

        /// <summary>visual_axis_sort_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#visual_axis_sort_option QuicksightDashboard#visual_axis_sort_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "visualAxisSortOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualAxisSortOption\"}", isOptional: true)]
        public aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualAxisSortOption? VisualAxisSortOption
        {
            get;
            set;
        }

        /// <summary>visual_menu_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#visual_menu_option QuicksightDashboard#visual_menu_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "visualMenuOption", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualMenuOption\"}", isOptional: true)]
        public aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualMenuOption? VisualMenuOption
        {
            get;
            set;
        }
    }
}
