namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AmplifyBranchState<'AppId, 'BranchName> = { assignments: ResizeArray<aws.AmplifyBranch.AmplifyBranchConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch">aws_amplify_branch</a>.
    /// </summary>
    type AmplifyBranchBuilder(logicalId: string) =
        member _.Yield(_: unit) : AmplifyBranchState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AmplifyBranchState<Missing, Missing>)

        member _.Zero(()) : AmplifyBranchState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AmplifyBranchState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#app_id-1">AmplifyBranch#app_id</a>.
        /// </summary>
        [<CustomOperation "app_id">]
        member _.AppId(state: AmplifyBranchState<Missing, 'BranchName>, value: string) : AmplifyBranchState<Present, 'BranchName> =
            state.assignments.Add(fun config -> config.AppId <- value)
            ({ assignments = state.assignments } : AmplifyBranchState<Present, 'BranchName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#branch_name-1">AmplifyBranch#branch_name</a>.
        /// </summary>
        [<CustomOperation "branch_name">]
        member _.BranchName(state: AmplifyBranchState<'AppId, Missing>, value: string) : AmplifyBranchState<'AppId, Present> =
            state.assignments.Add(fun config -> config.BranchName <- value)
            ({ assignments = state.assignments } : AmplifyBranchState<'AppId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#backend_environment_arn-1">AmplifyBranch#backend_environment_arn</a>.
        /// </summary>
        [<CustomOperation "backend_environment_arn">]
        member _.BackendEnvironmentArn(state: AmplifyBranchState<'AppId, 'BranchName>, value: string) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.BackendEnvironmentArn <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#basic_auth_credentials-1">AmplifyBranch#basic_auth_credentials</a>.
        /// </summary>
        [<CustomOperation "basic_auth_credentials">]
        member _.BasicAuthCredentials(state: AmplifyBranchState<'AppId, 'BranchName>, value: string) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.BasicAuthCredentials <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#description-1">AmplifyBranch#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AmplifyBranchState<'AppId, 'BranchName>, value: string) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#display_name-1">AmplifyBranch#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: AmplifyBranchState<'AppId, 'BranchName>, value: string) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#enable_auto_build-1">AmplifyBranch#enable_auto_build</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_auto_build">]
        member _.EnableAutoBuild(state: AmplifyBranchState<'AppId, 'BranchName>, value: bool) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.EnableAutoBuild <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#enable_auto_build-1">AmplifyBranch#enable_auto_build</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_auto_build">]
        member _.EnableAutoBuild(state: AmplifyBranchState<'AppId, 'BranchName>, value: HashiCorp.Cdktf.IResolvable) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.EnableAutoBuild <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#enable_basic_auth-1">AmplifyBranch#enable_basic_auth</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_basic_auth">]
        member _.EnableBasicAuth(state: AmplifyBranchState<'AppId, 'BranchName>, value: bool) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.EnableBasicAuth <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#enable_basic_auth-1">AmplifyBranch#enable_basic_auth</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_basic_auth">]
        member _.EnableBasicAuth(state: AmplifyBranchState<'AppId, 'BranchName>, value: HashiCorp.Cdktf.IResolvable) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.EnableBasicAuth <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#enable_notification-1">AmplifyBranch#enable_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_notification">]
        member _.EnableNotification(state: AmplifyBranchState<'AppId, 'BranchName>, value: bool) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.EnableNotification <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#enable_notification-1">AmplifyBranch#enable_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_notification">]
        member _.EnableNotification(state: AmplifyBranchState<'AppId, 'BranchName>, value: HashiCorp.Cdktf.IResolvable) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.EnableNotification <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#enable_performance_mode-1">AmplifyBranch#enable_performance_mode</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_performance_mode">]
        member _.EnablePerformanceMode(state: AmplifyBranchState<'AppId, 'BranchName>, value: bool) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.EnablePerformanceMode <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#enable_performance_mode-1">AmplifyBranch#enable_performance_mode</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_performance_mode">]
        member _.EnablePerformanceMode(state: AmplifyBranchState<'AppId, 'BranchName>, value: HashiCorp.Cdktf.IResolvable) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.EnablePerformanceMode <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#enable_pull_request_preview-1">AmplifyBranch#enable_pull_request_preview</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_pull_request_preview">]
        member _.EnablePullRequestPreview(state: AmplifyBranchState<'AppId, 'BranchName>, value: bool) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.EnablePullRequestPreview <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#enable_pull_request_preview-1">AmplifyBranch#enable_pull_request_preview</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_pull_request_preview">]
        member _.EnablePullRequestPreview(state: AmplifyBranchState<'AppId, 'BranchName>, value: HashiCorp.Cdktf.IResolvable) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.EnablePullRequestPreview <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#environment_variables-1">AmplifyBranch#environment_variables</a>.
        /// </summary>
        [<CustomOperation "environment_variables">]
        member _.EnvironmentVariables(state: AmplifyBranchState<'AppId, 'BranchName>, value: seq<string * string>) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.EnvironmentVariables <- dict value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#framework-1">AmplifyBranch#framework</a>.
        /// </summary>
        [<CustomOperation "framework">]
        member _.Framework(state: AmplifyBranchState<'AppId, 'BranchName>, value: string) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.Framework <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#id-1">AmplifyBranch#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AmplifyBranchState<'AppId, 'BranchName>, value: string) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#pull_request_environment_name-1">AmplifyBranch#pull_request_environment_name</a>.
        /// </summary>
        [<CustomOperation "pull_request_environment_name">]
        member _.PullRequestEnvironmentName(state: AmplifyBranchState<'AppId, 'BranchName>, value: string) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.PullRequestEnvironmentName <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#stage-1">AmplifyBranch#stage</a>.
        /// </summary>
        [<CustomOperation "stage">]
        member _.Stage(state: AmplifyBranchState<'AppId, 'BranchName>, value: string) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.Stage <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#tags-1">AmplifyBranch#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AmplifyBranchState<'AppId, 'BranchName>, value: seq<string * string>) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#tags_all-1">AmplifyBranch#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AmplifyBranchState<'AppId, 'BranchName>, value: seq<string * string>) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_branch#ttl-1">AmplifyBranch#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: AmplifyBranchState<'AppId, 'BranchName>, value: string) : AmplifyBranchState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            state : AmplifyBranchState<'AppId, 'BranchName>

        member _.Run(state: AmplifyBranchState<Present, Present>) : aws.AmplifyBranch.AmplifyBranch =
            let config = aws.AmplifyBranch.AmplifyBranchConfig()
            for setter in state.assignments do
                setter config
            aws.AmplifyBranch.AmplifyBranch(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.amplifyBranch: missing required arguments. Must call: app_id, branch_name.", 9999, IsError = true)>]
        member _.Run(_: AmplifyBranchState<_, _>) : aws.AmplifyBranch.AmplifyBranch =
            Unchecked.defaultof<aws.AmplifyBranch.AmplifyBranch>
