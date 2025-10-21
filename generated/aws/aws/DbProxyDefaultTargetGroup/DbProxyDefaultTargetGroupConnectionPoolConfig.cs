using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbProxyDefaultTargetGroup
{
    [JsiiByValue(fqn: "aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConnectionPoolConfig")]
    public class DbProxyDefaultTargetGroupConnectionPoolConfig : aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupConnectionPoolConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#connection_borrow_timeout DbProxyDefaultTargetGroup#connection_borrow_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionBorrowTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectionBorrowTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#init_query DbProxyDefaultTargetGroup#init_query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initQuery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InitQuery
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#max_connections_percent DbProxyDefaultTargetGroup#max_connections_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConnectionsPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConnectionsPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#max_idle_connections_percent DbProxyDefaultTargetGroup#max_idle_connections_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxIdleConnectionsPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxIdleConnectionsPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#session_pinning_filters DbProxyDefaultTargetGroup#session_pinning_filters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionPinningFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SessionPinningFilters
        {
            get;
            set;
        }
    }
}
