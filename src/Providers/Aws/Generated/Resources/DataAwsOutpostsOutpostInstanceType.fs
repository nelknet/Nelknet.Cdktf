namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOutpostsOutpostInstanceTypeState<'Arn> = { assignments: ResizeArray<aws.DataAwsOutpostsOutpostInstanceType.DataAwsOutpostsOutpostInstanceTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost_instance_type">aws_outposts_outpost_instance_type</a>.
    /// </summary>
    type DataAwsOutpostsOutpostInstanceTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOutpostsOutpostInstanceTypeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOutpostsOutpostInstanceTypeState<Missing>)

        member _.Zero(()) : DataAwsOutpostsOutpostInstanceTypeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOutpostsOutpostInstanceTypeState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost_instance_type#arn-1">DataAwsOutpostsOutpostInstanceType#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsOutpostsOutpostInstanceTypeState<Missing>, value: string) : DataAwsOutpostsOutpostInstanceTypeState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsOutpostsOutpostInstanceTypeState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost_instance_type#id-1">DataAwsOutpostsOutpostInstanceType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOutpostsOutpostInstanceTypeState<'Arn>, value: string) : DataAwsOutpostsOutpostInstanceTypeState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOutpostsOutpostInstanceTypeState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost_instance_type#instance_type-1">DataAwsOutpostsOutpostInstanceType#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: DataAwsOutpostsOutpostInstanceTypeState<'Arn>, value: string) : DataAwsOutpostsOutpostInstanceTypeState<'Arn> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            state : DataAwsOutpostsOutpostInstanceTypeState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost_instance_type#preferred_instance_types-1">DataAwsOutpostsOutpostInstanceType#preferred_instance_types</a>.
        /// </summary>
        [<CustomOperation "preferred_instance_types">]
        member _.PreferredInstanceTypes(state: DataAwsOutpostsOutpostInstanceTypeState<'Arn>, value: seq<string>) : DataAwsOutpostsOutpostInstanceTypeState<'Arn> =
            state.assignments.Add(fun config -> config.PreferredInstanceTypes <- (value |> Seq.toArray))
            state : DataAwsOutpostsOutpostInstanceTypeState<'Arn>

        member _.Run(state: DataAwsOutpostsOutpostInstanceTypeState<Present>) : aws.DataAwsOutpostsOutpostInstanceType.DataAwsOutpostsOutpostInstanceType =
            let config = aws.DataAwsOutpostsOutpostInstanceType.DataAwsOutpostsOutpostInstanceTypeConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOutpostsOutpostInstanceType.DataAwsOutpostsOutpostInstanceType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOutpostsOutpostInstanceType: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOutpostsOutpostInstanceTypeState<_>) : aws.DataAwsOutpostsOutpostInstanceType.DataAwsOutpostsOutpostInstanceType =
            Unchecked.defaultof<aws.DataAwsOutpostsOutpostInstanceType.DataAwsOutpostsOutpostInstanceType>
