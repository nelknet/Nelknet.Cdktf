namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TagState<'Key, 'ResourceId, 'Value> = { assignments: ResizeArray<aws.Ec2Tag.Ec2TagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_tag">aws_ec2_tag</a>.
    /// </summary>
    type Ec2TagBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TagState<Missing, Missing, Missing>)

        member _.Zero(()) : Ec2TagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TagState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_tag#key-1">Ec2Tag#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: Ec2TagState<Missing, 'ResourceId, 'Value>, value: string) : Ec2TagState<Present, 'ResourceId, 'Value> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : Ec2TagState<Present, 'ResourceId, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_tag#resource_id-1">Ec2Tag#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: Ec2TagState<'Key, Missing, 'Value>, value: string) : Ec2TagState<'Key, Present, 'Value> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : Ec2TagState<'Key, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_tag#value-1">Ec2Tag#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: Ec2TagState<'Key, 'ResourceId, Missing>, value: string) : Ec2TagState<'Key, 'ResourceId, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : Ec2TagState<'Key, 'ResourceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_tag#id-1">Ec2Tag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TagState<'Key, 'ResourceId, 'Value>, value: string) : Ec2TagState<'Key, 'ResourceId, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TagState<'Key, 'ResourceId, 'Value>

        member _.Run(state: Ec2TagState<Present, Present, Present>) : aws.Ec2Tag.Ec2Tag =
            let config = aws.Ec2Tag.Ec2TagConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2Tag.Ec2Tag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2Tag: missing required arguments. Must call: key, resource_id, value.", 9999, IsError = true)>]
        member _.Run(_: Ec2TagState<_, _, _>) : aws.Ec2Tag.Ec2Tag =
            Unchecked.defaultof<aws.Ec2Tag.Ec2Tag>
