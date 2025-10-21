using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiInterface(nativeType: typeof(IEmrClusterKerberosAttributes), fullyQualifiedName: "aws.emrCluster.EmrClusterKerberosAttributes")]
    public interface IEmrClusterKerberosAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#kdc_admin_password EmrCluster#kdc_admin_password}.</summary>
        [JsiiProperty(name: "kdcAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        string KdcAdminPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#realm EmrCluster#realm}.</summary>
        [JsiiProperty(name: "realm", typeJson: "{\"primitive\":\"string\"}")]
        string Realm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#ad_domain_join_password EmrCluster#ad_domain_join_password}.</summary>
        [JsiiProperty(name: "adDomainJoinPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdDomainJoinPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#ad_domain_join_user EmrCluster#ad_domain_join_user}.</summary>
        [JsiiProperty(name: "adDomainJoinUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdDomainJoinUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#cross_realm_trust_principal_password EmrCluster#cross_realm_trust_principal_password}.</summary>
        [JsiiProperty(name: "crossRealmTrustPrincipalPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrossRealmTrustPrincipalPassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterKerberosAttributes), fullyQualifiedName: "aws.emrCluster.EmrClusterKerberosAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.EmrCluster.IEmrClusterKerberosAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#kdc_admin_password EmrCluster#kdc_admin_password}.</summary>
            [JsiiProperty(name: "kdcAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string KdcAdminPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#realm EmrCluster#realm}.</summary>
            [JsiiProperty(name: "realm", typeJson: "{\"primitive\":\"string\"}")]
            public string Realm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#ad_domain_join_password EmrCluster#ad_domain_join_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adDomainJoinPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdDomainJoinPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#ad_domain_join_user EmrCluster#ad_domain_join_user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adDomainJoinUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdDomainJoinUser
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#cross_realm_trust_principal_password EmrCluster#cross_realm_trust_principal_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crossRealmTrustPrincipalPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrossRealmTrustPrincipalPassword
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
