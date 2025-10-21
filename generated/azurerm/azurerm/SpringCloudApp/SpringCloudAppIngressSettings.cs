using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudApp
{
    [JsiiByValue(fqn: "azurerm.springCloudApp.SpringCloudAppIngressSettings")]
    public class SpringCloudAppIngressSettings : azurerm.SpringCloudApp.ISpringCloudAppIngressSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#backend_protocol SpringCloudApp#backend_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backendProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackendProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#read_timeout_in_seconds SpringCloudApp#read_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadTimeoutInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#send_timeout_in_seconds SpringCloudApp#send_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sendTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SendTimeoutInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#session_affinity SpringCloudApp#session_affinity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionAffinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SessionAffinity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#session_cookie_max_age SpringCloudApp#session_cookie_max_age}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionCookieMaxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SessionCookieMaxAge
        {
            get;
            set;
        }
    }
}
