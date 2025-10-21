using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Provider
{
    [JsiiInterface(nativeType: typeof(IAwsProviderConfig), fullyQualifiedName: "aws.provider.AwsProviderConfig")]
    public interface IAwsProviderConfig
    {
        /// <summary>The access key for API operations. You can retrieve this from the 'Security &amp; Credentials' section of the AWS console.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#access_key AwsProvider#access_key}
        /// </remarks>
        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#alias AwsProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#allowed_account_ids AwsProvider#allowed_account_ids}.</summary>
        [JsiiProperty(name: "allowedAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedAccountIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>assume_role block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#assume_role AwsProvider#assume_role}
        /// </remarks>
        [JsiiProperty(name: "assumeRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.provider.AwsProviderAssumeRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AssumeRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>assume_role_with_web_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#assume_role_with_web_identity AwsProvider#assume_role_with_web_identity}
        /// </remarks>
        [JsiiProperty(name: "assumeRoleWithWebIdentity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.provider.AwsProviderAssumeRoleWithWebIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AssumeRoleWithWebIdentity
        {
            get
            {
                return null;
            }
        }

        /// <summary>File containing custom root and intermediate certificates.</summary>
        /// <remarks>
        /// Can also be configured using the <c>AWS_CA_BUNDLE</c> environment variable. (Setting <c>ca_bundle</c> in the shared config file is not supported.)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#custom_ca_bundle AwsProvider#custom_ca_bundle}
        /// </remarks>
        [JsiiProperty(name: "customCaBundle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomCaBundle
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#default_tags AwsProvider#default_tags}
        /// </remarks>
        [JsiiProperty(name: "defaultTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.provider.AwsProviderDefaultTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Address of the EC2 metadata service endpoint to use. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT` environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#ec2_metadata_service_endpoint AwsProvider#ec2_metadata_service_endpoint}
        /// </remarks>
        [JsiiProperty(name: "ec2MetadataServiceEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ec2MetadataServiceEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Protocol to use with EC2 metadata service endpoint.Valid values are `IPv4` and `IPv6`. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE` environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#ec2_metadata_service_endpoint_mode AwsProvider#ec2_metadata_service_endpoint_mode}
        /// </remarks>
        [JsiiProperty(name: "ec2MetadataServiceEndpointMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ec2MetadataServiceEndpointMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>endpoints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#endpoints AwsProvider#endpoints}
        /// </remarks>
        [JsiiProperty(name: "endpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.provider.AwsProviderEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Endpoints
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#forbidden_account_ids AwsProvider#forbidden_account_ids}.</summary>
        [JsiiProperty(name: "forbiddenAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ForbiddenAccountIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of a proxy to use for HTTP requests when accessing the AWS API.</summary>
        /// <remarks>
        /// Can also be set using the <c>HTTP_PROXY</c> or <c>http_proxy</c> environment variables.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#http_proxy AwsProvider#http_proxy}
        /// </remarks>
        [JsiiProperty(name: "httpProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of a proxy to use for HTTPS requests when accessing the AWS API.</summary>
        /// <remarks>
        /// Can also be set using the <c>HTTPS_PROXY</c> or <c>https_proxy</c> environment variables.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#https_proxy AwsProvider#https_proxy}
        /// </remarks>
        [JsiiProperty(name: "httpsProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpsProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>ignore_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#ignore_tags AwsProvider#ignore_tags}
        /// </remarks>
        [JsiiProperty(name: "ignoreTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.provider.AwsProviderIgnoreTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Explicitly allow the provider to perform "insecure" SSL requests. If omitted, default value is `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#insecure AwsProvider#insecure}
        /// </remarks>
        [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Insecure
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum number of times an AWS API request is being executed.</summary>
        /// <remarks>
        /// If the API request still fails, an error is
        /// thrown.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#max_retries AwsProvider#max_retries}
        /// </remarks>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Comma-separated list of hosts that should not use HTTP or HTTPS proxies.</summary>
        /// <remarks>
        /// Can also be set using the <c>NO_PROXY</c> or <c>no_proxy</c> environment variables.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#no_proxy AwsProvider#no_proxy}
        /// </remarks>
        [JsiiProperty(name: "noProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NoProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>The profile for API operations. If not set, the default profile created with `aws configure` will be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#profile AwsProvider#profile}
        /// </remarks>
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Profile
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region where AWS operations will take place. Examples are us-east-1, us-west-2, etc.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#region AwsProvider#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies how retries are attempted.</summary>
        /// <remarks>
        /// Valid values are <c>standard</c> and <c>adaptive</c>. Can also be configured using the <c>AWS_RETRY_MODE</c> environment variable.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#retry_mode AwsProvider#retry_mode}
        /// </remarks>
        [JsiiProperty(name: "retryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RetryMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether S3 API calls in the `us-east-1` region use the legacy global endpoint or a regional endpoint.</summary>
        /// <remarks>
        /// Valid values are <c>legacy</c> or <c>regional</c>. Can also be configured using the <c>AWS_S3_US_EAST_1_REGIONAL_ENDPOINT</c> environment variable or the <c>s3_us_east_1_regional_endpoint</c> shared config file parameter
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#s3_us_east_1_regional_endpoint AwsProvider#s3_us_east_1_regional_endpoint}
        /// </remarks>
        [JsiiProperty(name: "s3UsEast1RegionalEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3UsEast1RegionalEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set this to true to enable the request to use path-style addressing, i.e., https://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will use virtual hosted bucket addressing when possible (https://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#s3_use_path_style AwsProvider#s3_use_path_style}
        /// </remarks>
        [JsiiProperty(name: "s3UsePathStyle", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3UsePathStyle
        {
            get
            {
                return null;
            }
        }

        /// <summary>The secret key for API operations. You can retrieve this from the 'Security &amp; Credentials' section of the AWS console.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#secret_key AwsProvider#secret_key}
        /// </remarks>
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of paths to shared config files. If not set, defaults to [~/.aws/config].</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#shared_config_files AwsProvider#shared_config_files}
        /// </remarks>
        [JsiiProperty(name: "sharedConfigFiles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SharedConfigFiles
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of paths to shared credentials files. If not set, defaults to [~/.aws/credentials].</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#shared_credentials_files AwsProvider#shared_credentials_files}
        /// </remarks>
        [JsiiProperty(name: "sharedCredentialsFiles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SharedCredentialsFiles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip the credentials validation via STS API. Used for AWS API implementations that do not have STS available/implemented.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_credentials_validation AwsProvider#skip_credentials_validation}
        /// </remarks>
        [JsiiProperty(name: "skipCredentialsValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipCredentialsValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip the AWS Metadata API check. Used for AWS API implementations that do not have a metadata api endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_metadata_api_check AwsProvider#skip_metadata_api_check}
        /// </remarks>
        [JsiiProperty(name: "skipMetadataApiCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SkipMetadataApiCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip static validation of region name.</summary>
        /// <remarks>
        /// Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_region_validation AwsProvider#skip_region_validation}
        /// </remarks>
        [JsiiProperty(name: "skipRegionValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipRegionValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip requesting the account ID. Used for AWS API implementations that do not have IAM/STS API and/or metadata API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_requesting_account_id AwsProvider#skip_requesting_account_id}
        /// </remarks>
        [JsiiProperty(name: "skipRequestingAccountId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipRequestingAccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region where AWS STS operations will take place. Examples are us-east-1 and us-west-2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#sts_region AwsProvider#sts_region}
        /// </remarks>
        [JsiiProperty(name: "stsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StsRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>session token. A session token is only required if you are using temporary security credentials.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#token AwsProvider#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        /// <summary>The capacity of the AWS SDK's token bucket rate limiter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#token_bucket_rate_limiter_capacity AwsProvider#token_bucket_rate_limiter_capacity}
        /// </remarks>
        [JsiiProperty(name: "tokenBucketRateLimiterCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TokenBucketRateLimiterCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Resolve an endpoint with DualStack capability.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#use_dualstack_endpoint AwsProvider#use_dualstack_endpoint}
        /// </remarks>
        [JsiiProperty(name: "useDualstackEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseDualstackEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Resolve an endpoint with FIPS capability.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#use_fips_endpoint AwsProvider#use_fips_endpoint}
        /// </remarks>
        [JsiiProperty(name: "useFipsEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseFipsEndpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAwsProviderConfig), fullyQualifiedName: "aws.provider.AwsProviderConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Provider.IAwsProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The access key for API operations. You can retrieve this from the 'Security &amp; Credentials' section of the AWS console.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#access_key AwsProvider#access_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#alias AwsProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#allowed_account_ids AwsProvider#allowed_account_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAccountIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>assume_role block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#assume_role AwsProvider#assume_role}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assumeRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.provider.AwsProviderAssumeRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AssumeRole
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>assume_role_with_web_identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#assume_role_with_web_identity AwsProvider#assume_role_with_web_identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assumeRoleWithWebIdentity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.provider.AwsProviderAssumeRoleWithWebIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AssumeRoleWithWebIdentity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>File containing custom root and intermediate certificates.</summary>
            /// <remarks>
            /// Can also be configured using the <c>AWS_CA_BUNDLE</c> environment variable. (Setting <c>ca_bundle</c> in the shared config file is not supported.)
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#custom_ca_bundle AwsProvider#custom_ca_bundle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customCaBundle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomCaBundle
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>default_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#default_tags AwsProvider#default_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.provider.AwsProviderDefaultTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DefaultTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Address of the EC2 metadata service endpoint to use. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT` environment variable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#ec2_metadata_service_endpoint AwsProvider#ec2_metadata_service_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2MetadataServiceEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ec2MetadataServiceEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Protocol to use with EC2 metadata service endpoint.Valid values are `IPv4` and `IPv6`. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE` environment variable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#ec2_metadata_service_endpoint_mode AwsProvider#ec2_metadata_service_endpoint_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2MetadataServiceEndpointMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ec2MetadataServiceEndpointMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>endpoints block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#endpoints AwsProvider#endpoints}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.provider.AwsProviderEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Endpoints
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#forbidden_account_ids AwsProvider#forbidden_account_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forbiddenAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ForbiddenAccountIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>URL of a proxy to use for HTTP requests when accessing the AWS API.</summary>
            /// <remarks>
            /// Can also be set using the <c>HTTP_PROXY</c> or <c>http_proxy</c> environment variables.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#http_proxy AwsProvider#http_proxy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpProxy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>URL of a proxy to use for HTTPS requests when accessing the AWS API.</summary>
            /// <remarks>
            /// Can also be set using the <c>HTTPS_PROXY</c> or <c>https_proxy</c> environment variables.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#https_proxy AwsProvider#https_proxy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpsProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpsProxy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ignore_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#ignore_tags AwsProvider#ignore_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.provider.AwsProviderIgnoreTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IgnoreTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Explicitly allow the provider to perform "insecure" SSL requests. If omitted, default value is `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#insecure AwsProvider#insecure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Insecure
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The maximum number of times an AWS API request is being executed.</summary>
            /// <remarks>
            /// If the API request still fails, an error is
            /// thrown.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#max_retries AwsProvider#max_retries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRetries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Comma-separated list of hosts that should not use HTTP or HTTPS proxies.</summary>
            /// <remarks>
            /// Can also be set using the <c>NO_PROXY</c> or <c>no_proxy</c> environment variables.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#no_proxy AwsProvider#no_proxy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "noProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NoProxy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The profile for API operations. If not set, the default profile created with `aws configure` will be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#profile AwsProvider#profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Profile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region where AWS operations will take place. Examples are us-east-1, us-west-2, etc.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#region AwsProvider#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies how retries are attempted.</summary>
            /// <remarks>
            /// Valid values are <c>standard</c> and <c>adaptive</c>. Can also be configured using the <c>AWS_RETRY_MODE</c> environment variable.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#retry_mode AwsProvider#retry_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RetryMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies whether S3 API calls in the `us-east-1` region use the legacy global endpoint or a regional endpoint.</summary>
            /// <remarks>
            /// Valid values are <c>legacy</c> or <c>regional</c>. Can also be configured using the <c>AWS_S3_US_EAST_1_REGIONAL_ENDPOINT</c> environment variable or the <c>s3_us_east_1_regional_endpoint</c> shared config file parameter
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#s3_us_east_1_regional_endpoint AwsProvider#s3_us_east_1_regional_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3UsEast1RegionalEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3UsEast1RegionalEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set this to true to enable the request to use path-style addressing, i.e., https://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will use virtual hosted bucket addressing when possible (https://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#s3_use_path_style AwsProvider#s3_use_path_style}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3UsePathStyle", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? S3UsePathStyle
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The secret key for API operations. You can retrieve this from the 'Security &amp; Credentials' section of the AWS console.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#secret_key AwsProvider#secret_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of paths to shared config files. If not set, defaults to [~/.aws/config].</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#shared_config_files AwsProvider#shared_config_files}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sharedConfigFiles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SharedConfigFiles
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of paths to shared credentials files. If not set, defaults to [~/.aws/credentials].</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#shared_credentials_files AwsProvider#shared_credentials_files}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sharedCredentialsFiles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SharedCredentialsFiles
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Skip the credentials validation via STS API. Used for AWS API implementations that do not have STS available/implemented.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_credentials_validation AwsProvider#skip_credentials_validation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipCredentialsValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipCredentialsValidation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Skip the AWS Metadata API check. Used for AWS API implementations that do not have a metadata api endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_metadata_api_check AwsProvider#skip_metadata_api_check}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipMetadataApiCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SkipMetadataApiCheck
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Skip static validation of region name.</summary>
            /// <remarks>
            /// Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_region_validation AwsProvider#skip_region_validation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipRegionValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipRegionValidation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Skip requesting the account ID. Used for AWS API implementations that do not have IAM/STS API and/or metadata API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_requesting_account_id AwsProvider#skip_requesting_account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipRequestingAccountId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipRequestingAccountId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The region where AWS STS operations will take place. Examples are us-east-1 and us-west-2.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#sts_region AwsProvider#sts_region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StsRegion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>session token. A session token is only required if you are using temporary security credentials.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#token AwsProvider#token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Token
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The capacity of the AWS SDK's token bucket rate limiter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#token_bucket_rate_limiter_capacity AwsProvider#token_bucket_rate_limiter_capacity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenBucketRateLimiterCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TokenBucketRateLimiterCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Resolve an endpoint with DualStack capability.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#use_dualstack_endpoint AwsProvider#use_dualstack_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useDualstackEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseDualstackEndpoint
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Resolve an endpoint with FIPS capability.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#use_fips_endpoint AwsProvider#use_fips_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useFipsEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseFipsEndpoint
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
