using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCognitoUserPool
{
    [JsiiClass(nativeType: typeof(aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigOutputReference), fullyQualifiedName: "aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsCognitoUserPoolLambdaConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsCognitoUserPoolLambdaConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsCognitoUserPoolLambdaConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCognitoUserPoolLambdaConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createAuthChallenge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateAuthChallenge
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customEmailSender", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigCustomEmailSenderList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigCustomEmailSenderList CustomEmailSender
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigCustomEmailSenderList>()!;
        }

        [JsiiProperty(name: "customMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customSmsSender", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigCustomSmsSenderList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigCustomSmsSenderList CustomSmsSender
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigCustomSmsSenderList>()!;
        }

        [JsiiProperty(name: "defineAuthChallenge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefineAuthChallenge
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "postAuthentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostAuthentication
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "postConfirmation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostConfirmation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preAuthentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreAuthentication
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preSignUp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreSignUp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preTokenGeneration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreTokenGeneration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preTokenGenerationConfig", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigPreTokenGenerationConfigList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigPreTokenGenerationConfigList PreTokenGenerationConfig
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigPreTokenGenerationConfigList>()!;
        }

        [JsiiProperty(name: "userMigration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserMigration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "verifyAuthChallengeResponse", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerifyAuthChallengeResponse
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfig\"}", isOptional: true)]
        public virtual aws.DataAwsCognitoUserPool.IDataAwsCognitoUserPoolLambdaConfig? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.IDataAwsCognitoUserPoolLambdaConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
