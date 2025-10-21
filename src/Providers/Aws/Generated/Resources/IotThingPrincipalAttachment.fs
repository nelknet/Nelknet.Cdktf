namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotThingPrincipalAttachmentState<'Principal, 'Thing> = { assignments: ResizeArray<aws.IotThingPrincipalAttachment.IotThingPrincipalAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_principal_attachment">aws_iot_thing_principal_attachment</a>.
    /// </summary>
    type IotThingPrincipalAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotThingPrincipalAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotThingPrincipalAttachmentState<Missing, Missing>)

        member _.Zero(()) : IotThingPrincipalAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotThingPrincipalAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_principal_attachment#principal-1">IotThingPrincipalAttachment#principal</a>.
        /// </summary>
        [<CustomOperation "principal">]
        member _.Principal(state: IotThingPrincipalAttachmentState<Missing, 'Thing>, value: string) : IotThingPrincipalAttachmentState<Present, 'Thing> =
            state.assignments.Add(fun config -> config.Principal <- value)
            ({ assignments = state.assignments } : IotThingPrincipalAttachmentState<Present, 'Thing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_principal_attachment#thing-1">IotThingPrincipalAttachment#thing</a>.
        /// </summary>
        [<CustomOperation "thing">]
        member _.Thing(state: IotThingPrincipalAttachmentState<'Principal, Missing>, value: string) : IotThingPrincipalAttachmentState<'Principal, Present> =
            state.assignments.Add(fun config -> config.Thing <- value)
            ({ assignments = state.assignments } : IotThingPrincipalAttachmentState<'Principal, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_principal_attachment#id-1">IotThingPrincipalAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotThingPrincipalAttachmentState<'Principal, 'Thing>, value: string) : IotThingPrincipalAttachmentState<'Principal, 'Thing> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotThingPrincipalAttachmentState<'Principal, 'Thing>

        member _.Run(state: IotThingPrincipalAttachmentState<Present, Present>) : aws.IotThingPrincipalAttachment.IotThingPrincipalAttachment =
            let config = aws.IotThingPrincipalAttachment.IotThingPrincipalAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.IotThingPrincipalAttachment.IotThingPrincipalAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotThingPrincipalAttachment: missing required arguments. Must call: principal, thing.", 9999, IsError = true)>]
        member _.Run(_: IotThingPrincipalAttachmentState<_, _>) : aws.IotThingPrincipalAttachment.IotThingPrincipalAttachment =
            Unchecked.defaultof<aws.IotThingPrincipalAttachment.IotThingPrincipalAttachment>
