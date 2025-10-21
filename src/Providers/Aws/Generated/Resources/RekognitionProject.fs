namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RekognitionProjectState<'Name> = { assignments: ResizeArray<aws.RekognitionProject.RekognitionProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_project">aws_rekognition_project</a>.
    /// </summary>
    type RekognitionProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : RekognitionProjectState<Missing> =
            ({ assignments = ResizeArray() } : RekognitionProjectState<Missing>)

        member _.Zero(()) : RekognitionProjectState<Missing> =
            ({ assignments = ResizeArray() } : RekognitionProjectState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_project#name-1">RekognitionProject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RekognitionProjectState<Missing>, value: string) : RekognitionProjectState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RekognitionProjectState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_project#auto_update-1">RekognitionProject#auto_update</a>.
        /// </summary>
        [<CustomOperation "auto_update">]
        member _.AutoUpdate(state: RekognitionProjectState<'Name>, value: string) : RekognitionProjectState<'Name> =
            state.assignments.Add(fun config -> config.AutoUpdate <- value)
            state : RekognitionProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_project#feature-1">RekognitionProject#feature</a>.
        /// </summary>
        [<CustomOperation "feature">]
        member _.Feature(state: RekognitionProjectState<'Name>, value: string) : RekognitionProjectState<'Name> =
            state.assignments.Add(fun config -> config.Feature <- value)
            state : RekognitionProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_project#tags-1">RekognitionProject#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RekognitionProjectState<'Name>, value: seq<string * string>) : RekognitionProjectState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RekognitionProjectState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_project#timeouts-1">RekognitionProject#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RekognitionProjectState<'Name>, value: aws.RekognitionProject.RekognitionProjectTimeouts) : RekognitionProjectState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RekognitionProjectState<'Name>

        member _.Run(state: RekognitionProjectState<Present>) : aws.RekognitionProject.RekognitionProject =
            let config = aws.RekognitionProject.RekognitionProjectConfig()
            for setter in state.assignments do
                setter config
            aws.RekognitionProject.RekognitionProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rekognitionProject: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: RekognitionProjectState<_>) : aws.RekognitionProject.RekognitionProject =
            Unchecked.defaultof<aws.RekognitionProject.RekognitionProject>
