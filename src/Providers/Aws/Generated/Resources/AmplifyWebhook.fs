namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AmplifyWebhookState<'AppId, 'BranchName> = { assignments: ResizeArray<aws.AmplifyWebhook.AmplifyWebhookConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_webhook">aws_amplify_webhook</a>.
    /// </summary>
    type AmplifyWebhookBuilder(logicalId: string) =
        member _.Yield(_: unit) : AmplifyWebhookState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AmplifyWebhookState<Missing, Missing>)

        member _.Zero(()) : AmplifyWebhookState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AmplifyWebhookState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_webhook#app_id-1">AmplifyWebhook#app_id</a>.
        /// </summary>
        [<CustomOperation "app_id">]
        member _.AppId(state: AmplifyWebhookState<Missing, 'BranchName>, value: string) : AmplifyWebhookState<Present, 'BranchName> =
            state.assignments.Add(fun config -> config.AppId <- value)
            ({ assignments = state.assignments } : AmplifyWebhookState<Present, 'BranchName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_webhook#branch_name-1">AmplifyWebhook#branch_name</a>.
        /// </summary>
        [<CustomOperation "branch_name">]
        member _.BranchName(state: AmplifyWebhookState<'AppId, Missing>, value: string) : AmplifyWebhookState<'AppId, Present> =
            state.assignments.Add(fun config -> config.BranchName <- value)
            ({ assignments = state.assignments } : AmplifyWebhookState<'AppId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_webhook#description-1">AmplifyWebhook#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AmplifyWebhookState<'AppId, 'BranchName>, value: string) : AmplifyWebhookState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AmplifyWebhookState<'AppId, 'BranchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_webhook#id-1">AmplifyWebhook#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AmplifyWebhookState<'AppId, 'BranchName>, value: string) : AmplifyWebhookState<'AppId, 'BranchName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AmplifyWebhookState<'AppId, 'BranchName>

        member _.Run(state: AmplifyWebhookState<Present, Present>) : aws.AmplifyWebhook.AmplifyWebhook =
            let config = aws.AmplifyWebhook.AmplifyWebhookConfig()
            for setter in state.assignments do
                setter config
            aws.AmplifyWebhook.AmplifyWebhook(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.amplifyWebhook: missing required arguments. Must call: app_id, branch_name.", 9999, IsError = true)>]
        member _.Run(_: AmplifyWebhookState<_, _>) : aws.AmplifyWebhook.AmplifyWebhook =
            Unchecked.defaultof<aws.AmplifyWebhook.AmplifyWebhook>
