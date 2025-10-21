namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodecatalystProjectState<'DisplayName, 'SpaceName> = { assignments: ResizeArray<aws.CodecatalystProject.CodecatalystProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_project">aws_codecatalyst_project</a>.
    /// </summary>
    type CodecatalystProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodecatalystProjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecatalystProjectState<Missing, Missing>)

        member _.Zero(()) : CodecatalystProjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecatalystProjectState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_project#display_name-1">CodecatalystProject#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: CodecatalystProjectState<Missing, 'SpaceName>, value: string) : CodecatalystProjectState<Present, 'SpaceName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : CodecatalystProjectState<Present, 'SpaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_project#space_name-1">CodecatalystProject#space_name</a>.
        /// </summary>
        [<CustomOperation "space_name">]
        member _.SpaceName(state: CodecatalystProjectState<'DisplayName, Missing>, value: string) : CodecatalystProjectState<'DisplayName, Present> =
            state.assignments.Add(fun config -> config.SpaceName <- value)
            ({ assignments = state.assignments } : CodecatalystProjectState<'DisplayName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_project#description-1">CodecatalystProject#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CodecatalystProjectState<'DisplayName, 'SpaceName>, value: string) : CodecatalystProjectState<'DisplayName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CodecatalystProjectState<'DisplayName, 'SpaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_project#id-1">CodecatalystProject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodecatalystProjectState<'DisplayName, 'SpaceName>, value: string) : CodecatalystProjectState<'DisplayName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodecatalystProjectState<'DisplayName, 'SpaceName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_project#timeouts-1">CodecatalystProject#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CodecatalystProjectState<'DisplayName, 'SpaceName>, value: aws.CodecatalystProject.CodecatalystProjectTimeouts) : CodecatalystProjectState<'DisplayName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CodecatalystProjectState<'DisplayName, 'SpaceName>

        member _.Run(state: CodecatalystProjectState<Present, Present>) : aws.CodecatalystProject.CodecatalystProject =
            let config = aws.CodecatalystProject.CodecatalystProjectConfig()
            for setter in state.assignments do
                setter config
            aws.CodecatalystProject.CodecatalystProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codecatalystProject: missing required arguments. Must call: display_name, space_name.", 9999, IsError = true)>]
        member _.Run(_: CodecatalystProjectState<_, _>) : aws.CodecatalystProject.CodecatalystProject =
            Unchecked.defaultof<aws.CodecatalystProject.CodecatalystProject>
