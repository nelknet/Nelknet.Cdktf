namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type InternetGatewayAttachmentState<'InternetGatewayId, 'VpcId> = { assignments: ResizeArray<aws.InternetGatewayAttachment.InternetGatewayAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internet_gateway_attachment">aws_internet_gateway_attachment</a>.
    /// </summary>
    type InternetGatewayAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : InternetGatewayAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : InternetGatewayAttachmentState<Missing, Missing>)

        member _.Zero(()) : InternetGatewayAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : InternetGatewayAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internet_gateway_attachment#internet_gateway_id-1">InternetGatewayAttachment#internet_gateway_id</a>.
        /// </summary>
        [<CustomOperation "internet_gateway_id">]
        member _.InternetGatewayId(state: InternetGatewayAttachmentState<Missing, 'VpcId>, value: string) : InternetGatewayAttachmentState<Present, 'VpcId> =
            state.assignments.Add(fun config -> config.InternetGatewayId <- value)
            ({ assignments = state.assignments } : InternetGatewayAttachmentState<Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internet_gateway_attachment#vpc_id-1">InternetGatewayAttachment#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: InternetGatewayAttachmentState<'InternetGatewayId, Missing>, value: string) : InternetGatewayAttachmentState<'InternetGatewayId, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : InternetGatewayAttachmentState<'InternetGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internet_gateway_attachment#id-1">InternetGatewayAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: InternetGatewayAttachmentState<'InternetGatewayId, 'VpcId>, value: string) : InternetGatewayAttachmentState<'InternetGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : InternetGatewayAttachmentState<'InternetGatewayId, 'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/internet_gateway_attachment#timeouts-1">InternetGatewayAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: InternetGatewayAttachmentState<'InternetGatewayId, 'VpcId>, value: aws.InternetGatewayAttachment.InternetGatewayAttachmentTimeouts) : InternetGatewayAttachmentState<'InternetGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : InternetGatewayAttachmentState<'InternetGatewayId, 'VpcId>

        member _.Run(state: InternetGatewayAttachmentState<Present, Present>) : aws.InternetGatewayAttachment.InternetGatewayAttachment =
            let config = aws.InternetGatewayAttachment.InternetGatewayAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.InternetGatewayAttachment.InternetGatewayAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.internetGatewayAttachment: missing required arguments. Must call: internet_gateway_id, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: InternetGatewayAttachmentState<_, _>) : aws.InternetGatewayAttachment.InternetGatewayAttachment =
            Unchecked.defaultof<aws.InternetGatewayAttachment.InternetGatewayAttachment>
