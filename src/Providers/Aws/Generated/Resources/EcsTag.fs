namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcsTagState<'Key, 'ResourceArn, 'Value> = { assignments: ResizeArray<aws.EcsTag.EcsTagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_tag">aws_ecs_tag</a>.
    /// </summary>
    type EcsTagBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcsTagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EcsTagState<Missing, Missing, Missing>)

        member _.Zero(()) : EcsTagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EcsTagState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_tag#key-1">EcsTag#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: EcsTagState<Missing, 'ResourceArn, 'Value>, value: string) : EcsTagState<Present, 'ResourceArn, 'Value> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : EcsTagState<Present, 'ResourceArn, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_tag#resource_arn-1">EcsTag#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: EcsTagState<'Key, Missing, 'Value>, value: string) : EcsTagState<'Key, Present, 'Value> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : EcsTagState<'Key, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_tag#value-1">EcsTag#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: EcsTagState<'Key, 'ResourceArn, Missing>, value: string) : EcsTagState<'Key, 'ResourceArn, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : EcsTagState<'Key, 'ResourceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_tag#id-1">EcsTag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcsTagState<'Key, 'ResourceArn, 'Value>, value: string) : EcsTagState<'Key, 'ResourceArn, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcsTagState<'Key, 'ResourceArn, 'Value>

        member _.Run(state: EcsTagState<Present, Present, Present>) : aws.EcsTag.EcsTag =
            let config = aws.EcsTag.EcsTagConfig()
            for setter in state.assignments do
                setter config
            aws.EcsTag.EcsTag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecsTag: missing required arguments. Must call: key, resource_arn, value.", 9999, IsError = true)>]
        member _.Run(_: EcsTagState<_, _, _>) : aws.EcsTag.EcsTag =
            Unchecked.defaultof<aws.EcsTag.EcsTag>
