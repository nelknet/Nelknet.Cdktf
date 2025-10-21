using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolLambdaConfig")]
    public class CognitoUserPoolLambdaConfig : aws.CognitoUserPool.ICognitoUserPoolLambdaConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#create_auth_challenge CognitoUserPool#create_auth_challenge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "createAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreateAuthChallenge
        {
            get;
            set;
        }

        /// <summary>custom_email_sender block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#custom_email_sender CognitoUserPool#custom_email_sender}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customEmailSender", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolLambdaConfigCustomEmailSender\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolLambdaConfigCustomEmailSender? CustomEmailSender
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#custom_message CognitoUserPool#custom_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomMessage
        {
            get;
            set;
        }

        /// <summary>custom_sms_sender block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#custom_sms_sender CognitoUserPool#custom_sms_sender}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customSmsSender", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolLambdaConfigCustomSmsSender\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolLambdaConfigCustomSmsSender? CustomSmsSender
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#define_auth_challenge CognitoUserPool#define_auth_challenge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defineAuthChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefineAuthChallenge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#kms_key_id CognitoUserPool#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#post_authentication CognitoUserPool#post_authentication}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "postAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PostAuthentication
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#post_confirmation CognitoUserPool#post_confirmation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "postConfirmation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PostConfirmation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#pre_authentication CognitoUserPool#pre_authentication}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preAuthentication", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreAuthentication
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#pre_sign_up CognitoUserPool#pre_sign_up}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preSignUp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreSignUp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#pre_token_generation CognitoUserPool#pre_token_generation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preTokenGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreTokenGeneration
        {
            get;
            set;
        }

        /// <summary>pre_token_generation_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#pre_token_generation_config CognitoUserPool#pre_token_generation_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preTokenGenerationConfig", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolLambdaConfigPreTokenGenerationConfig\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolLambdaConfigPreTokenGenerationConfig? PreTokenGenerationConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_migration CognitoUserPool#user_migration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userMigration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserMigration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#verify_auth_challenge_response CognitoUserPool#verify_auth_challenge_response}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifyAuthChallengeResponse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VerifyAuthChallengeResponse
        {
            get;
            set;
        }
    }
}
