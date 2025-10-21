namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn> = { assignments: ResizeArray<aws.NetworkmanagerVpcAttachment.NetworkmanagerVpcAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_vpc_attachment">aws_networkmanager_vpc_attachment</a>.
    /// </summary>
    type NetworkmanagerVpcAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerVpcAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerVpcAttachmentState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkmanagerVpcAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerVpcAttachmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_vpc_attachment#core_network_id-1">NetworkmanagerVpcAttachment#core_network_id</a>.
        /// </summary>
        [<CustomOperation "core_network_id">]
        member _.CoreNetworkId(state: NetworkmanagerVpcAttachmentState<Missing, 'SubnetArns, 'VpcArn>, value: string) : NetworkmanagerVpcAttachmentState<Present, 'SubnetArns, 'VpcArn> =
            state.assignments.Add(fun config -> config.CoreNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerVpcAttachmentState<Present, 'SubnetArns, 'VpcArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_vpc_attachment#subnet_arns-1">NetworkmanagerVpcAttachment#subnet_arns</a>.
        /// </summary>
        [<CustomOperation "subnet_arns">]
        member _.SubnetArns(state: NetworkmanagerVpcAttachmentState<'CoreNetworkId, Missing, 'VpcArn>, value: seq<string>) : NetworkmanagerVpcAttachmentState<'CoreNetworkId, Present, 'VpcArn> =
            state.assignments.Add(fun config -> config.SubnetArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : NetworkmanagerVpcAttachmentState<'CoreNetworkId, Present, 'VpcArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_vpc_attachment#vpc_arn-1">NetworkmanagerVpcAttachment#vpc_arn</a>.
        /// </summary>
        [<CustomOperation "vpc_arn">]
        member _.VpcArn(state: NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, Missing>, value: string) : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, Present> =
            state.assignments.Add(fun config -> config.VpcArn <- value)
            ({ assignments = state.assignments } : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_vpc_attachment#id-1">NetworkmanagerVpcAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn>, value: string) : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn>

        /// <summary>
        /// options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_vpc_attachment#options-1">NetworkmanagerVpcAttachment#options</a>
        /// </summary>
        [<CustomOperation "options">]
        member _.Options(state: NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn>, value: aws.NetworkmanagerVpcAttachment.NetworkmanagerVpcAttachmentOptions) : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn> =
            state.assignments.Add(fun config -> config.Options <- value)
            state : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_vpc_attachment#tags-1">NetworkmanagerVpcAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn>, value: seq<string * string>) : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_vpc_attachment#tags_all-1">NetworkmanagerVpcAttachment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn>, value: seq<string * string>) : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_vpc_attachment#timeouts-1">NetworkmanagerVpcAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn>, value: aws.NetworkmanagerVpcAttachment.NetworkmanagerVpcAttachmentTimeouts) : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerVpcAttachmentState<'CoreNetworkId, 'SubnetArns, 'VpcArn>

        member _.Run(state: NetworkmanagerVpcAttachmentState<Present, Present, Present>) : aws.NetworkmanagerVpcAttachment.NetworkmanagerVpcAttachment =
            let config = aws.NetworkmanagerVpcAttachment.NetworkmanagerVpcAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerVpcAttachment.NetworkmanagerVpcAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerVpcAttachment: missing required arguments. Must call: core_network_id, subnet_arns, vpc_arn.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerVpcAttachmentState<_, _, _>) : aws.NetworkmanagerVpcAttachment.NetworkmanagerVpcAttachment =
            Unchecked.defaultof<aws.NetworkmanagerVpcAttachment.NetworkmanagerVpcAttachment>
