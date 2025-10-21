namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppsyncTypeState<'ApiId, 'Definition, 'Format> = { assignments: ResizeArray<aws.AppsyncType.AppsyncTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_type">aws_appsync_type</a>.
    /// </summary>
    type AppsyncTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppsyncTypeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncTypeState<Missing, Missing, Missing>)

        member _.Zero(()) : AppsyncTypeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncTypeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_type#api_id-1">AppsyncType#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: AppsyncTypeState<Missing, 'Definition, 'Format>, value: string) : AppsyncTypeState<Present, 'Definition, 'Format> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : AppsyncTypeState<Present, 'Definition, 'Format>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_type#definition-1">AppsyncType#definition</a>.
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: AppsyncTypeState<'ApiId, Missing, 'Format>, value: string) : AppsyncTypeState<'ApiId, Present, 'Format> =
            state.assignments.Add(fun config -> config.Definition <- value)
            ({ assignments = state.assignments } : AppsyncTypeState<'ApiId, Present, 'Format>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_type#format-1">AppsyncType#format</a>.
        /// </summary>
        [<CustomOperation "format">]
        member _.Format(state: AppsyncTypeState<'ApiId, 'Definition, Missing>, value: string) : AppsyncTypeState<'ApiId, 'Definition, Present> =
            state.assignments.Add(fun config -> config.Format <- value)
            ({ assignments = state.assignments } : AppsyncTypeState<'ApiId, 'Definition, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_type#id-1">AppsyncType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppsyncTypeState<'ApiId, 'Definition, 'Format>, value: string) : AppsyncTypeState<'ApiId, 'Definition, 'Format> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppsyncTypeState<'ApiId, 'Definition, 'Format>

        member _.Run(state: AppsyncTypeState<Present, Present, Present>) : aws.AppsyncType.AppsyncType =
            let config = aws.AppsyncType.AppsyncTypeConfig()
            for setter in state.assignments do
                setter config
            aws.AppsyncType.AppsyncType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appsyncType: missing required arguments. Must call: api_id, definition, format.", 9999, IsError = true)>]
        member _.Run(_: AppsyncTypeState<_, _, _>) : aws.AppsyncType.AppsyncType =
            Unchecked.defaultof<aws.AppsyncType.AppsyncType>
