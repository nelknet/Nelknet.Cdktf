namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EvidentlyFeatureState<'Name, 'Project, 'Variations> = { assignments: ResizeArray<aws.EvidentlyFeature.EvidentlyFeatureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature">aws_evidently_feature</a>.
    /// </summary>
    type EvidentlyFeatureBuilder(logicalId: string) =
        member _.Yield(_: unit) : EvidentlyFeatureState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EvidentlyFeatureState<Missing, Missing, Missing>)

        member _.Zero(()) : EvidentlyFeatureState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EvidentlyFeatureState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#name-1">EvidentlyFeature#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EvidentlyFeatureState<Missing, 'Project, 'Variations>, value: string) : EvidentlyFeatureState<Present, 'Project, 'Variations> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EvidentlyFeatureState<Present, 'Project, 'Variations>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#project-1">EvidentlyFeature#project</a>.
        /// </summary>
        [<CustomOperation "project">]
        member _.Project(state: EvidentlyFeatureState<'Name, Missing, 'Variations>, value: string) : EvidentlyFeatureState<'Name, Present, 'Variations> =
            state.assignments.Add(fun config -> config.Project <- value)
            ({ assignments = state.assignments } : EvidentlyFeatureState<'Name, Present, 'Variations>)

        /// <summary>
        /// variations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#variations-1">EvidentlyFeature#variations</a> Accepts: aws.IResolvable | aws.EvidentlyFeature.EvidentlyFeatureVariations[]
        /// </summary>
        [<CustomOperation "variations">]
        member _.Variations(state: EvidentlyFeatureState<'Name, 'Project, Missing>, value: HashiCorp.Cdktf.IResolvable) : EvidentlyFeatureState<'Name, 'Project, Present> =
            state.assignments.Add(fun config -> config.Variations <- value)
            ({ assignments = state.assignments } : EvidentlyFeatureState<'Name, 'Project, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#default_variation-1">EvidentlyFeature#default_variation</a>.
        /// </summary>
        [<CustomOperation "default_variation">]
        member _.DefaultVariation(state: EvidentlyFeatureState<'Name, 'Project, 'Variations>, value: string) : EvidentlyFeatureState<'Name, 'Project, 'Variations> =
            state.assignments.Add(fun config -> config.DefaultVariation <- value)
            state : EvidentlyFeatureState<'Name, 'Project, 'Variations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#description-1">EvidentlyFeature#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: EvidentlyFeatureState<'Name, 'Project, 'Variations>, value: string) : EvidentlyFeatureState<'Name, 'Project, 'Variations> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : EvidentlyFeatureState<'Name, 'Project, 'Variations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#entity_overrides-1">EvidentlyFeature#entity_overrides</a>.
        /// </summary>
        [<CustomOperation "entity_overrides">]
        member _.EntityOverrides(state: EvidentlyFeatureState<'Name, 'Project, 'Variations>, value: seq<string * string>) : EvidentlyFeatureState<'Name, 'Project, 'Variations> =
            state.assignments.Add(fun config -> config.EntityOverrides <- dict value)
            state : EvidentlyFeatureState<'Name, 'Project, 'Variations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#evaluation_strategy-1">EvidentlyFeature#evaluation_strategy</a>.
        /// </summary>
        [<CustomOperation "evaluation_strategy">]
        member _.EvaluationStrategy(state: EvidentlyFeatureState<'Name, 'Project, 'Variations>, value: string) : EvidentlyFeatureState<'Name, 'Project, 'Variations> =
            state.assignments.Add(fun config -> config.EvaluationStrategy <- value)
            state : EvidentlyFeatureState<'Name, 'Project, 'Variations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#id-1">EvidentlyFeature#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EvidentlyFeatureState<'Name, 'Project, 'Variations>, value: string) : EvidentlyFeatureState<'Name, 'Project, 'Variations> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EvidentlyFeatureState<'Name, 'Project, 'Variations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#tags-1">EvidentlyFeature#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EvidentlyFeatureState<'Name, 'Project, 'Variations>, value: seq<string * string>) : EvidentlyFeatureState<'Name, 'Project, 'Variations> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EvidentlyFeatureState<'Name, 'Project, 'Variations>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#tags_all-1">EvidentlyFeature#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EvidentlyFeatureState<'Name, 'Project, 'Variations>, value: seq<string * string>) : EvidentlyFeatureState<'Name, 'Project, 'Variations> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EvidentlyFeatureState<'Name, 'Project, 'Variations>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#timeouts-1">EvidentlyFeature#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EvidentlyFeatureState<'Name, 'Project, 'Variations>, value: aws.EvidentlyFeature.EvidentlyFeatureTimeouts) : EvidentlyFeatureState<'Name, 'Project, 'Variations> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EvidentlyFeatureState<'Name, 'Project, 'Variations>

        member _.Run(state: EvidentlyFeatureState<Present, Present, Present>) : aws.EvidentlyFeature.EvidentlyFeature =
            let config = aws.EvidentlyFeature.EvidentlyFeatureConfig()
            for setter in state.assignments do
                setter config
            aws.EvidentlyFeature.EvidentlyFeature(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.evidentlyFeature: missing required arguments. Must call: name, project, variations.", 9999, IsError = true)>]
        member _.Run(_: EvidentlyFeatureState<_, _, _>) : aws.EvidentlyFeature.EvidentlyFeature =
            Unchecked.defaultof<aws.EvidentlyFeature.EvidentlyFeature>
