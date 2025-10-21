using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodegurureviewerRepositoryAssociation
{
    [JsiiInterface(nativeType: typeof(ICodegurureviewerRepositoryAssociationRepository), fullyQualifiedName: "aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepository")]
    public interface ICodegurureviewerRepositoryAssociationRepository
    {
        /// <summary>bitbucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#bitbucket CodegurureviewerRepositoryAssociation#bitbucket}
        /// </remarks>
        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryBitbucket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryBitbucket? Bitbucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>codecommit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#codecommit CodegurureviewerRepositoryAssociation#codecommit}
        /// </remarks>
        [JsiiProperty(name: "codecommit", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryCodecommit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryCodecommit? Codecommit
        {
            get
            {
                return null;
            }
        }

        /// <summary>github_enterprise_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#github_enterprise_server CodegurureviewerRepositoryAssociation#github_enterprise_server}
        /// </remarks>
        [JsiiProperty(name: "githubEnterpriseServer", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer? GithubEnterpriseServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#s3_bucket CodegurureviewerRepositoryAssociation#s3_bucket}
        /// </remarks>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryS3Bucket\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryS3Bucket? S3Bucket
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodegurureviewerRepositoryAssociationRepository), fullyQualifiedName: "aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepository")]
        internal sealed class _Proxy : DeputyBase, aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepository
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bitbucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#bitbucket CodegurureviewerRepositoryAssociation#bitbucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryBitbucket\"}", isOptional: true)]
            public aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryBitbucket? Bitbucket
            {
                get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryBitbucket?>();
            }

            /// <summary>codecommit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#codecommit CodegurureviewerRepositoryAssociation#codecommit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codecommit", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryCodecommit\"}", isOptional: true)]
            public aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryCodecommit? Codecommit
            {
                get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryCodecommit?>();
            }

            /// <summary>github_enterprise_server block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#github_enterprise_server CodegurureviewerRepositoryAssociation#github_enterprise_server}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "githubEnterpriseServer", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer\"}", isOptional: true)]
            public aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer? GithubEnterpriseServer
            {
                get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer?>();
            }

            /// <summary>s3_bucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codegurureviewer_repository_association#s3_bucket CodegurureviewerRepositoryAssociation#s3_bucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Bucket", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryS3Bucket\"}", isOptional: true)]
            public aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryS3Bucket? S3Bucket
            {
                get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryS3Bucket?>();
            }
        }
    }
}
