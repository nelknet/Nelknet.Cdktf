namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AwsProviderState = { assignments: ResizeArray<aws.Provider.AwsProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs">aws</a>.
    /// </summary>
    type AwsProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : AwsProviderState =
            { assignments = ResizeArray() }

        member _.Zero(()) : AwsProviderState =
            { assignments = ResizeArray() }

        /// <summary>
        /// The access key for API operations. You can retrieve this from the 'Security & Credentials' section of the AWS console. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#access_key-1">AwsProvider#access_key</a>
        /// </summary>
        [<CustomOperation "access_key">]
        member _.AccessKey(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.AccessKey <- value)
            state : AwsProviderState

        /// <summary>
        /// Alias name. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#alias-1">AwsProvider#alias</a>
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.Alias <- value)
            state : AwsProviderState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#allowed_account_ids-1">AwsProvider#allowed_account_ids</a>.
        /// </summary>
        [<CustomOperation "allowed_account_ids">]
        member _.AllowedAccountIds(state: AwsProviderState, value: seq<string>) : AwsProviderState =
            state.assignments.Add(fun config -> config.AllowedAccountIds <- (value |> Seq.toArray))
            state : AwsProviderState

        /// <summary>
        /// assume_role block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#assume_role-1">AwsProvider#assume_role</a> Accepts: aws.IResolvable | aws.Provider.AwsProviderAssumeRole[]
        /// </summary>
        [<CustomOperation "assume_role">]
        member _.AssumeRole(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.AssumeRole <- value)
            state : AwsProviderState

        /// <summary>
        /// assume_role_with_web_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#assume_role_with_web_identity-1">AwsProvider#assume_role_with_web_identity</a> Accepts: aws.IResolvable | aws.Provider.AwsProviderAssumeRoleWithWebIdentity[]
        /// </summary>
        [<CustomOperation "assume_role_with_web_identity">]
        member _.AssumeRoleWithWebIdentity(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.AssumeRoleWithWebIdentity <- value)
            state : AwsProviderState

        /// <summary>
        /// File containing custom root and intermediate certificates. Can also be configured using the `AWS_CA_BUNDLE` environment variable. (Setting `ca_bundle` in the shared config file is not supported.) Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#custom_ca_bundle-1">AwsProvider#custom_ca_bundle</a>
        /// </summary>
        [<CustomOperation "custom_ca_bundle">]
        member _.CustomCaBundle(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.CustomCaBundle <- value)
            state : AwsProviderState

        /// <summary>
        /// default_tags block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#default_tags-1">AwsProvider#default_tags</a> Accepts: aws.IResolvable | aws.Provider.AwsProviderDefaultTags[]
        /// </summary>
        [<CustomOperation "default_tags">]
        member _.DefaultTags(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.DefaultTags <- value)
            state : AwsProviderState

        /// <summary>
        /// Address of the EC2 metadata service endpoint to use. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT` environment variable. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#ec2_metadata_service_endpoint-1">AwsProvider#ec2_metadata_service_endpoint</a>
        /// </summary>
        [<CustomOperation "ec2_metadata_service_endpoint">]
        member _.Ec2MetadataServiceEndpoint(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.Ec2MetadataServiceEndpoint <- value)
            state : AwsProviderState

        /// <summary>
        /// Protocol to use with EC2 metadata service endpoint.Valid values are `IPv4` and `IPv6`. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE` environment variable. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#ec2_metadata_service_endpoint_mode-1">AwsProvider#ec2_metadata_service_endpoint_mode</a>
        /// </summary>
        [<CustomOperation "ec2_metadata_service_endpoint_mode">]
        member _.Ec2MetadataServiceEndpointMode(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.Ec2MetadataServiceEndpointMode <- value)
            state : AwsProviderState

        /// <summary>
        /// endpoints block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#endpoints-1">AwsProvider#endpoints</a> Accepts: aws.IResolvable | aws.Provider.AwsProviderEndpoints[]
        /// </summary>
        [<CustomOperation "endpoints">]
        member _.Endpoints(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.Endpoints <- value)
            state : AwsProviderState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#forbidden_account_ids-1">AwsProvider#forbidden_account_ids</a>.
        /// </summary>
        [<CustomOperation "forbidden_account_ids">]
        member _.ForbiddenAccountIds(state: AwsProviderState, value: seq<string>) : AwsProviderState =
            state.assignments.Add(fun config -> config.ForbiddenAccountIds <- (value |> Seq.toArray))
            state : AwsProviderState

        /// <summary>
        /// URL of a proxy to use for HTTP requests when accessing the AWS API. Can also be set using the `HTTP_PROXY` or `http_proxy` environment variables. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#http_proxy-1">AwsProvider#http_proxy</a>
        /// </summary>
        [<CustomOperation "http_proxy">]
        member _.HttpProxy(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.HttpProxy <- value)
            state : AwsProviderState

        /// <summary>
        /// URL of a proxy to use for HTTPS requests when accessing the AWS API. Can also be set using the `HTTPS_PROXY` or `https_proxy` environment variables. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#https_proxy-1">AwsProvider#https_proxy</a>
        /// </summary>
        [<CustomOperation "https_proxy">]
        member _.HttpsProxy(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.HttpsProxy <- value)
            state : AwsProviderState

        /// <summary>
        /// ignore_tags block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#ignore_tags-1">AwsProvider#ignore_tags</a> Accepts: aws.IResolvable | aws.Provider.AwsProviderIgnoreTags[]
        /// </summary>
        [<CustomOperation "ignore_tags">]
        member _.IgnoreTags(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.IgnoreTags <- value)
            state : AwsProviderState

        /// <summary>
        /// Explicitly allow the provider to perform "insecure" SSL requests. If omitted, default value is `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#insecure-1">AwsProvider#insecure</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "insecure">]
        member _.Insecure(state: AwsProviderState, value: bool) : AwsProviderState =
            state.assignments.Add(fun config -> config.Insecure <- value)
            state : AwsProviderState

        /// <summary>
        /// Explicitly allow the provider to perform "insecure" SSL requests. If omitted, default value is `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#insecure-1">AwsProvider#insecure</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "insecure">]
        member _.Insecure(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.Insecure <- value)
            state : AwsProviderState

        /// <summary>
        /// The maximum number of times an AWS API request is being executed. If the API request still fails, an error is thrown. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#max_retries-1">AwsProvider#max_retries</a>
        /// </summary>
        [<CustomOperation "max_retries">]
        member _.MaxRetries(state: AwsProviderState, value: double) : AwsProviderState =
            state.assignments.Add(fun config -> config.MaxRetries <- value)
            state : AwsProviderState

        /// <summary>
        /// Comma-separated list of hosts that should not use HTTP or HTTPS proxies. Can also be set using the `NO_PROXY` or `no_proxy` environment variables. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#no_proxy-1">AwsProvider#no_proxy</a>
        /// </summary>
        [<CustomOperation "no_proxy">]
        member _.NoProxy(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.NoProxy <- value)
            state : AwsProviderState

        /// <summary>
        /// The profile for API operations. If not set, the default profile created with `aws configure` will be used. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#profile-1">AwsProvider#profile</a>
        /// </summary>
        [<CustomOperation "profile">]
        member _.Profile(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.Profile <- value)
            state : AwsProviderState

        /// <summary>
        /// The region where AWS operations will take place. Examples are us-east-1, us-west-2, etc. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#region-1">AwsProvider#region</a>
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.Region <- value)
            state : AwsProviderState

        /// <summary>
        /// Specifies how retries are attempted. Valid values are `standard` and `adaptive`. Can also be configured using the `AWS_RETRY_MODE` environment variable. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#retry_mode-1">AwsProvider#retry_mode</a>
        /// </summary>
        [<CustomOperation "retry_mode">]
        member _.RetryMode(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.RetryMode <- value)
            state : AwsProviderState

        /// <summary>
        /// Specifies whether S3 API calls in the `us-east-1` region use the legacy global endpoint or a regional endpoint. Valid values are `legacy` or `regional`. Can also be configured using the `AWS_S3_US_EAST_1_REGIONAL_ENDPOINT` environment variable or the `s3_us_east_1_regional_endpoint` shared config file parameter Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#s3_us_east_1_regional_endpoint-1">AwsProvider#s3_us_east_1_regional_endpoint</a>
        /// </summary>
        [<CustomOperation "s3_us_east1_regional_endpoint">]
        member _.S3UsEast1RegionalEndpoint(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.S3UsEast1RegionalEndpoint <- value)
            state : AwsProviderState

        /// <summary>
        /// Set this to true to enable the request to use path-style addressing, i.e., https://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will use virtual hosted bucket addressing when possible (https://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#s3_use_path_style-1">AwsProvider#s3_use_path_style</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "s3_use_path_style">]
        member _.S3UsePathStyle(state: AwsProviderState, value: bool) : AwsProviderState =
            state.assignments.Add(fun config -> config.S3UsePathStyle <- value)
            state : AwsProviderState

        /// <summary>
        /// Set this to true to enable the request to use path-style addressing, i.e., https://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will use virtual hosted bucket addressing when possible (https://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#s3_use_path_style-1">AwsProvider#s3_use_path_style</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "s3_use_path_style">]
        member _.S3UsePathStyle(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.S3UsePathStyle <- value)
            state : AwsProviderState

        /// <summary>
        /// The secret key for API operations. You can retrieve this from the 'Security & Credentials' section of the AWS console. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#secret_key-1">AwsProvider#secret_key</a>
        /// </summary>
        [<CustomOperation "secret_key">]
        member _.SecretKey(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.SecretKey <- value)
            state : AwsProviderState

        /// <summary>
        /// List of paths to shared config files. If not set, defaults to [~/.aws/config]. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#shared_config_files-1">AwsProvider#shared_config_files</a>
        /// </summary>
        [<CustomOperation "shared_config_files">]
        member _.SharedConfigFiles(state: AwsProviderState, value: seq<string>) : AwsProviderState =
            state.assignments.Add(fun config -> config.SharedConfigFiles <- (value |> Seq.toArray))
            state : AwsProviderState

        /// <summary>
        /// List of paths to shared credentials files. If not set, defaults to [~/.aws/credentials]. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#shared_credentials_files-1">AwsProvider#shared_credentials_files</a>
        /// </summary>
        [<CustomOperation "shared_credentials_files">]
        member _.SharedCredentialsFiles(state: AwsProviderState, value: seq<string>) : AwsProviderState =
            state.assignments.Add(fun config -> config.SharedCredentialsFiles <- (value |> Seq.toArray))
            state : AwsProviderState

        /// <summary>
        /// Skip the credentials validation via STS API. Used for AWS API implementations that do not have STS available/implemented. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_credentials_validation-1">AwsProvider#skip_credentials_validation</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_credentials_validation">]
        member _.SkipCredentialsValidation(state: AwsProviderState, value: bool) : AwsProviderState =
            state.assignments.Add(fun config -> config.SkipCredentialsValidation <- value)
            state : AwsProviderState

        /// <summary>
        /// Skip the credentials validation via STS API. Used for AWS API implementations that do not have STS available/implemented. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_credentials_validation-1">AwsProvider#skip_credentials_validation</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_credentials_validation">]
        member _.SkipCredentialsValidation(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.SkipCredentialsValidation <- value)
            state : AwsProviderState

        /// <summary>
        /// Skip the AWS Metadata API check. Used for AWS API implementations that do not have a metadata api endpoint. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_metadata_api_check-1">AwsProvider#skip_metadata_api_check</a>
        /// </summary>
        [<CustomOperation "skip_metadata_api_check">]
        member _.SkipMetadataApiCheck(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.SkipMetadataApiCheck <- value)
            state : AwsProviderState

        /// <summary>
        /// Skip static validation of region name. Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_region_validation-1">AwsProvider#skip_region_validation</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_region_validation">]
        member _.SkipRegionValidation(state: AwsProviderState, value: bool) : AwsProviderState =
            state.assignments.Add(fun config -> config.SkipRegionValidation <- value)
            state : AwsProviderState

        /// <summary>
        /// Skip static validation of region name. Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_region_validation-1">AwsProvider#skip_region_validation</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_region_validation">]
        member _.SkipRegionValidation(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.SkipRegionValidation <- value)
            state : AwsProviderState

        /// <summary>
        /// Skip requesting the account ID. Used for AWS API implementations that do not have IAM/STS API and/or metadata API. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_requesting_account_id-1">AwsProvider#skip_requesting_account_id</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_requesting_account_id">]
        member _.SkipRequestingAccountId(state: AwsProviderState, value: bool) : AwsProviderState =
            state.assignments.Add(fun config -> config.SkipRequestingAccountId <- value)
            state : AwsProviderState

        /// <summary>
        /// Skip requesting the account ID. Used for AWS API implementations that do not have IAM/STS API and/or metadata API. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#skip_requesting_account_id-1">AwsProvider#skip_requesting_account_id</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_requesting_account_id">]
        member _.SkipRequestingAccountId(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.SkipRequestingAccountId <- value)
            state : AwsProviderState

        /// <summary>
        /// The region where AWS STS operations will take place. Examples are us-east-1 and us-west-2. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#sts_region-1">AwsProvider#sts_region</a>
        /// </summary>
        [<CustomOperation "sts_region">]
        member _.StsRegion(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.StsRegion <- value)
            state : AwsProviderState

        /// <summary>
        /// session token. A session token is only required if you are using temporary security credentials. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#token-1">AwsProvider#token</a>
        /// </summary>
        [<CustomOperation "token">]
        member _.Token(state: AwsProviderState, value: string) : AwsProviderState =
            state.assignments.Add(fun config -> config.Token <- value)
            state : AwsProviderState

        /// <summary>
        /// The capacity of the AWS SDK's token bucket rate limiter. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#token_bucket_rate_limiter_capacity-1">AwsProvider#token_bucket_rate_limiter_capacity</a>
        /// </summary>
        [<CustomOperation "token_bucket_rate_limiter_capacity">]
        member _.TokenBucketRateLimiterCapacity(state: AwsProviderState, value: double) : AwsProviderState =
            state.assignments.Add(fun config -> config.TokenBucketRateLimiterCapacity <- value)
            state : AwsProviderState

        /// <summary>
        /// Resolve an endpoint with DualStack capability. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#use_dualstack_endpoint-1">AwsProvider#use_dualstack_endpoint</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_dualstack_endpoint">]
        member _.UseDualstackEndpoint(state: AwsProviderState, value: bool) : AwsProviderState =
            state.assignments.Add(fun config -> config.UseDualstackEndpoint <- value)
            state : AwsProviderState

        /// <summary>
        /// Resolve an endpoint with DualStack capability. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#use_dualstack_endpoint-1">AwsProvider#use_dualstack_endpoint</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_dualstack_endpoint">]
        member _.UseDualstackEndpoint(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.UseDualstackEndpoint <- value)
            state : AwsProviderState

        /// <summary>
        /// Resolve an endpoint with FIPS capability. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#use_fips_endpoint-1">AwsProvider#use_fips_endpoint</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_fips_endpoint">]
        member _.UseFipsEndpoint(state: AwsProviderState, value: bool) : AwsProviderState =
            state.assignments.Add(fun config -> config.UseFipsEndpoint <- value)
            state : AwsProviderState

        /// <summary>
        /// Resolve an endpoint with FIPS capability. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#use_fips_endpoint-1">AwsProvider#use_fips_endpoint</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_fips_endpoint">]
        member _.UseFipsEndpoint(state: AwsProviderState, value: HashiCorp.Cdktf.IResolvable) : AwsProviderState =
            state.assignments.Add(fun config -> config.UseFipsEndpoint <- value)
            state : AwsProviderState

        member _.Run(state: AwsProviderState) : aws.Provider.AwsProvider =
            let config = aws.Provider.AwsProviderConfig()
            for setter in state.assignments do
                setter config
            aws.Provider.AwsProvider(StackContext.get (), logicalId, config)
