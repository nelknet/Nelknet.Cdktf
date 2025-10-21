using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodegurureviewerRepositoryAssociation
{
    [JsiiClass(nativeType: typeof(aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryOutputReference), fullyQualifiedName: "aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodegurureviewerRepositoryAssociationRepositoryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodegurureviewerRepositoryAssociationRepositoryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CodegurureviewerRepositoryAssociationRepositoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodegurureviewerRepositoryAssociationRepositoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBitbucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryBitbucket\"}}]")]
        public virtual void PutBitbucket(aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryBitbucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryBitbucket)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCodecommit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryCodecommit\"}}]")]
        public virtual void PutCodecommit(aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryCodecommit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryCodecommit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithubEnterpriseServer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer\"}}]")]
        public virtual void PutGithubEnterpriseServer(aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Bucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryS3Bucket\"}}]")]
        public virtual void PutS3Bucket(aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryS3Bucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryS3Bucket)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBitbucket")]
        public virtual void ResetBitbucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodecommit")]
        public virtual void ResetCodecommit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithubEnterpriseServer")]
        public virtual void ResetGithubEnterpriseServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Bucket")]
        public virtual void ResetS3Bucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryBitbucketOutputReference\"}")]
        public virtual aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryBitbucketOutputReference Bitbucket
        {
            get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryBitbucketOutputReference>()!;
        }

        [JsiiProperty(name: "codecommit", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryCodecommitOutputReference\"}")]
        public virtual aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryCodecommitOutputReference Codecommit
        {
            get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryCodecommitOutputReference>()!;
        }

        [JsiiProperty(name: "githubEnterpriseServer", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServerOutputReference\"}")]
        public virtual aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServerOutputReference GithubEnterpriseServer
        {
            get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServerOutputReference>()!;
        }

        [JsiiProperty(name: "s3Bucket", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryS3BucketOutputReference\"}")]
        public virtual aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryS3BucketOutputReference S3Bucket
        {
            get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryS3BucketOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitbucketInput", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryBitbucket\"}", isOptional: true)]
        public virtual aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryBitbucket? BitbucketInput
        {
            get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryBitbucket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codecommitInput", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryCodecommit\"}", isOptional: true)]
        public virtual aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryCodecommit? CodecommitInput
        {
            get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryCodecommit?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubEnterpriseServerInput", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer\"}", isOptional: true)]
        public virtual aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer? GithubEnterpriseServerInput
        {
            get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryGithubEnterpriseServer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketInput", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepositoryS3Bucket\"}", isOptional: true)]
        public virtual aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryS3Bucket? S3BucketInput
        {
            get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepositoryS3Bucket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codegurureviewerRepositoryAssociation.CodegurureviewerRepositoryAssociationRepository\"}", isOptional: true)]
        public virtual aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepository? InternalValue
        {
            get => GetInstanceProperty<aws.CodegurureviewerRepositoryAssociation.ICodegurureviewerRepositoryAssociationRepository?>();
            set => SetInstanceProperty(value);
        }
    }
}
