namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodedeployAppState<'Name> = { assignments: ResizeArray<aws.CodedeployApp.CodedeployAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_app">aws_codedeploy_app</a>.
    /// </summary>
    type CodedeployAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodedeployAppState<Missing> =
            ({ assignments = ResizeArray() } : CodedeployAppState<Missing>)

        member _.Zero(()) : CodedeployAppState<Missing> =
            ({ assignments = ResizeArray() } : CodedeployAppState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_app#name-1">CodedeployApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodedeployAppState<Missing>, value: string) : CodedeployAppState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodedeployAppState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_app#compute_platform-1">CodedeployApp#compute_platform</a>.
        /// </summary>
        [<CustomOperation "compute_platform">]
        member _.ComputePlatform(state: CodedeployAppState<'Name>, value: string) : CodedeployAppState<'Name> =
            state.assignments.Add(fun config -> config.ComputePlatform <- value)
            state : CodedeployAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_app#id-1">CodedeployApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodedeployAppState<'Name>, value: string) : CodedeployAppState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodedeployAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_app#tags-1">CodedeployApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodedeployAppState<'Name>, value: seq<string * string>) : CodedeployAppState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodedeployAppState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_app#tags_all-1">CodedeployApp#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodedeployAppState<'Name>, value: seq<string * string>) : CodedeployAppState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodedeployAppState<'Name>

        member _.Run(state: CodedeployAppState<Present>) : aws.CodedeployApp.CodedeployApp =
            let config = aws.CodedeployApp.CodedeployAppConfig()
            for setter in state.assignments do
                setter config
            aws.CodedeployApp.CodedeployApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codedeployApp: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CodedeployAppState<_>) : aws.CodedeployApp.CodedeployApp =
            Unchecked.defaultof<aws.CodedeployApp.CodedeployApp>
