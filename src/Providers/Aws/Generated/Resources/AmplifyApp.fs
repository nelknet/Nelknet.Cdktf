namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AmplifyAppState<'Name> = { assignments: ResizeArray<aws.AmplifyApp.AmplifyAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app">aws_amplify_app</a>.
    /// </summary>
    type AmplifyAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : AmplifyAppState<Missing> =
            ({ assignments = ResizeArray() } : AmplifyAppState<Missing>)

        member _.Zero(()) : AmplifyAppState<Missing> =
            ({ assignments = ResizeArray() } : AmplifyAppState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#name-1">AmplifyApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AmplifyAppState<Missing>, value: string) : AmplifyAppState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AmplifyAppState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#access_token-1">AmplifyApp#access_token</a>.
        /// </summary>
        [<CustomOperation "access_token">]
        member _.AccessToken(state: AmplifyAppState<'Name>, value: string) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.AccessToken <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// auto_branch_creation_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#auto_branch_creation_config-1">AmplifyApp#auto_branch_creation_config</a>
        /// </summary>
        [<CustomOperation "auto_branch_creation_config">]
        member _.AutoBranchCreationConfig(state: AmplifyAppState<'Name>, value: aws.AmplifyApp.AmplifyAppAutoBranchCreationConfig) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.AutoBranchCreationConfig <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#auto_branch_creation_patterns-1">AmplifyApp#auto_branch_creation_patterns</a>.
        /// </summary>
        [<CustomOperation "auto_branch_creation_patterns">]
        member _.AutoBranchCreationPatterns(state: AmplifyAppState<'Name>, value: seq<string>) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.AutoBranchCreationPatterns <- (value |> Seq.toArray))
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#basic_auth_credentials-1">AmplifyApp#basic_auth_credentials</a>.
        /// </summary>
        [<CustomOperation "basic_auth_credentials">]
        member _.BasicAuthCredentials(state: AmplifyAppState<'Name>, value: string) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.BasicAuthCredentials <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#build_spec-1">AmplifyApp#build_spec</a>.
        /// </summary>
        [<CustomOperation "build_spec">]
        member _.BuildSpec(state: AmplifyAppState<'Name>, value: string) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.BuildSpec <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// cache_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#cache_config-1">AmplifyApp#cache_config</a>
        /// </summary>
        [<CustomOperation "cache_config">]
        member _.CacheConfig(state: AmplifyAppState<'Name>, value: aws.AmplifyApp.AmplifyAppCacheConfig) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.CacheConfig <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#compute_role_arn-1">AmplifyApp#compute_role_arn</a>.
        /// </summary>
        [<CustomOperation "compute_role_arn">]
        member _.ComputeRoleArn(state: AmplifyAppState<'Name>, value: string) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.ComputeRoleArn <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#custom_headers-1">AmplifyApp#custom_headers</a>.
        /// </summary>
        [<CustomOperation "custom_headers">]
        member _.CustomHeaders(state: AmplifyAppState<'Name>, value: string) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.CustomHeaders <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// custom_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#custom_rule-1">AmplifyApp#custom_rule</a> Accepts: aws.IResolvable | aws.AmplifyApp.AmplifyAppCustomRule[]
        /// </summary>
        [<CustomOperation "custom_rule">]
        member _.CustomRule(state: AmplifyAppState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.CustomRule <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#description-1">AmplifyApp#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AmplifyAppState<'Name>, value: string) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#enable_auto_branch_creation-1">AmplifyApp#enable_auto_branch_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_auto_branch_creation">]
        member _.EnableAutoBranchCreation(state: AmplifyAppState<'Name>, value: bool) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.EnableAutoBranchCreation <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#enable_auto_branch_creation-1">AmplifyApp#enable_auto_branch_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_auto_branch_creation">]
        member _.EnableAutoBranchCreation(state: AmplifyAppState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.EnableAutoBranchCreation <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#enable_basic_auth-1">AmplifyApp#enable_basic_auth</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_basic_auth">]
        member _.EnableBasicAuth(state: AmplifyAppState<'Name>, value: bool) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.EnableBasicAuth <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#enable_basic_auth-1">AmplifyApp#enable_basic_auth</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_basic_auth">]
        member _.EnableBasicAuth(state: AmplifyAppState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.EnableBasicAuth <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#enable_branch_auto_build-1">AmplifyApp#enable_branch_auto_build</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_branch_auto_build">]
        member _.EnableBranchAutoBuild(state: AmplifyAppState<'Name>, value: bool) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.EnableBranchAutoBuild <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#enable_branch_auto_build-1">AmplifyApp#enable_branch_auto_build</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_branch_auto_build">]
        member _.EnableBranchAutoBuild(state: AmplifyAppState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.EnableBranchAutoBuild <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#enable_branch_auto_deletion-1">AmplifyApp#enable_branch_auto_deletion</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_branch_auto_deletion">]
        member _.EnableBranchAutoDeletion(state: AmplifyAppState<'Name>, value: bool) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.EnableBranchAutoDeletion <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#enable_branch_auto_deletion-1">AmplifyApp#enable_branch_auto_deletion</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_branch_auto_deletion">]
        member _.EnableBranchAutoDeletion(state: AmplifyAppState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.EnableBranchAutoDeletion <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#environment_variables-1">AmplifyApp#environment_variables</a>.
        /// </summary>
        [<CustomOperation "environment_variables">]
        member _.EnvironmentVariables(state: AmplifyAppState<'Name>, value: seq<string * string>) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.EnvironmentVariables <- dict value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#iam_service_role_arn-1">AmplifyApp#iam_service_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_service_role_arn">]
        member _.IamServiceRoleArn(state: AmplifyAppState<'Name>, value: string) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.IamServiceRoleArn <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#id-1">AmplifyApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AmplifyAppState<'Name>, value: string) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#oauth_token-1">AmplifyApp#oauth_token</a>.
        /// </summary>
        [<CustomOperation "oauth_token">]
        member _.OauthToken(state: AmplifyAppState<'Name>, value: string) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.OauthToken <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#platform-1">AmplifyApp#platform</a>.
        /// </summary>
        [<CustomOperation "platform">]
        member _.Platform(state: AmplifyAppState<'Name>, value: string) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.Platform <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#repository-1">AmplifyApp#repository</a>.
        /// </summary>
        [<CustomOperation "repository">]
        member _.Repository(state: AmplifyAppState<'Name>, value: string) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.Repository <- value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#tags-1">AmplifyApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AmplifyAppState<'Name>, value: seq<string * string>) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AmplifyAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#tags_all-1">AmplifyApp#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AmplifyAppState<'Name>, value: seq<string * string>) : AmplifyAppState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AmplifyAppState<'Name>

        member _.Run(state: AmplifyAppState<Present>) : aws.AmplifyApp.AmplifyApp =
            let config = aws.AmplifyApp.AmplifyAppConfig()
            for setter in state.assignments do
                setter config
            aws.AmplifyApp.AmplifyApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.amplifyApp: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: AmplifyAppState<_>) : aws.AmplifyApp.AmplifyApp =
            Unchecked.defaultof<aws.AmplifyApp.AmplifyApp>
