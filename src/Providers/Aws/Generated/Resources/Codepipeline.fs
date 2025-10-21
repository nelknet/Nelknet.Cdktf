namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage> = { assignments: ResizeArray<aws.Codepipeline.CodepipelineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline">aws_codepipeline</a>.
    /// </summary>
    type CodepipelineBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodepipelineState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodepipelineState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CodepipelineState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodepipelineState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// artifact_store block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#artifact_store-1">Codepipeline#artifact_store</a> Accepts: aws.IResolvable | aws.Codepipeline.CodepipelineArtifactStore[]
        /// </summary>
        [<CustomOperation "artifact_store">]
        member _.ArtifactStore(state: CodepipelineState<Missing, 'Name, 'RoleArn, 'Stage>, value: HashiCorp.Cdktf.IResolvable) : CodepipelineState<Present, 'Name, 'RoleArn, 'Stage> =
            state.assignments.Add(fun config -> config.ArtifactStore <- value)
            ({ assignments = state.assignments } : CodepipelineState<Present, 'Name, 'RoleArn, 'Stage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#name-1">Codepipeline#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodepipelineState<'ArtifactStore, Missing, 'RoleArn, 'Stage>, value: string) : CodepipelineState<'ArtifactStore, Present, 'RoleArn, 'Stage> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodepipelineState<'ArtifactStore, Present, 'RoleArn, 'Stage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#role_arn-1">Codepipeline#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: CodepipelineState<'ArtifactStore, 'Name, Missing, 'Stage>, value: string) : CodepipelineState<'ArtifactStore, 'Name, Present, 'Stage> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : CodepipelineState<'ArtifactStore, 'Name, Present, 'Stage>)

        /// <summary>
        /// stage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#stage-1">Codepipeline#stage</a> Accepts: aws.IResolvable | aws.Codepipeline.CodepipelineStage[]
        /// </summary>
        [<CustomOperation "stage">]
        member _.Stage(state: CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, Missing>, value: HashiCorp.Cdktf.IResolvable) : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.Stage <- value)
            ({ assignments = state.assignments } : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#execution_mode-1">Codepipeline#execution_mode</a>.
        /// </summary>
        [<CustomOperation "execution_mode">]
        member _.ExecutionMode(state: CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>, value: string) : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage> =
            state.assignments.Add(fun config -> config.ExecutionMode <- value)
            state : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#id-1">Codepipeline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>, value: string) : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#pipeline_type-1">Codepipeline#pipeline_type</a>.
        /// </summary>
        [<CustomOperation "pipeline_type">]
        member _.PipelineType(state: CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>, value: string) : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage> =
            state.assignments.Add(fun config -> config.PipelineType <- value)
            state : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#tags-1">Codepipeline#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>, value: seq<string * string>) : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#tags_all-1">Codepipeline#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>, value: seq<string * string>) : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>

        /// <summary>
        /// trigger block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#trigger-1">Codepipeline#trigger</a> Accepts: aws.IResolvable | aws.Codepipeline.CodepipelineTrigger[]
        /// </summary>
        [<CustomOperation "trigger">]
        member _.Trigger(state: CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>, value: HashiCorp.Cdktf.IResolvable) : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage> =
            state.assignments.Add(fun config -> config.Trigger <- value)
            state : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>

        /// <summary>
        /// variable block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#variable-1">Codepipeline#variable</a> Accepts: aws.IResolvable | aws.Codepipeline.CodepipelineVariable[]
        /// </summary>
        [<CustomOperation "variable">]
        member _.Variable(state: CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>, value: HashiCorp.Cdktf.IResolvable) : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage> =
            state.assignments.Add(fun config -> config.Variable <- value)
            state : CodepipelineState<'ArtifactStore, 'Name, 'RoleArn, 'Stage>

        member _.Run(state: CodepipelineState<Present, Present, Present, Present>) : aws.Codepipeline.Codepipeline =
            let config = aws.Codepipeline.CodepipelineConfig()
            for setter in state.assignments do
                setter config
            aws.Codepipeline.Codepipeline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codepipeline: missing required arguments. Must call: artifact_store, name, role_arn, stage.", 9999, IsError = true)>]
        member _.Run(_: CodepipelineState<_, _, _, _>) : aws.Codepipeline.Codepipeline =
            Unchecked.defaultof<aws.Codepipeline.Codepipeline>
