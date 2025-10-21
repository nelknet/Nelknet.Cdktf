using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetRefreshProperties")]
    public class QuicksightDataSetRefreshProperties : aws.QuicksightDataSet.IQuicksightDataSetRefreshProperties
    {
        /// <summary>refresh_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#refresh_configuration QuicksightDataSet#refresh_configuration}
        /// </remarks>
        [JsiiProperty(name: "refreshConfiguration", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfiguration\"}")]
        public aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfiguration RefreshConfiguration
        {
            get;
            set;
        }
    }
}
