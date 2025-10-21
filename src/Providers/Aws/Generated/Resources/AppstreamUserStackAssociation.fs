namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, 'UserName> = { assignments: ResizeArray<aws.AppstreamUserStackAssociation.AppstreamUserStackAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user_stack_association">aws_appstream_user_stack_association</a>.
    /// </summary>
    type AppstreamUserStackAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppstreamUserStackAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamUserStackAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : AppstreamUserStackAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamUserStackAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user_stack_association#authentication_type-1">AppstreamUserStackAssociation#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: AppstreamUserStackAssociationState<Missing, 'StackName, 'UserName>, value: string) : AppstreamUserStackAssociationState<Present, 'StackName, 'UserName> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            ({ assignments = state.assignments } : AppstreamUserStackAssociationState<Present, 'StackName, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user_stack_association#stack_name-1">AppstreamUserStackAssociation#stack_name</a>.
        /// </summary>
        [<CustomOperation "stack_name">]
        member _.StackName(state: AppstreamUserStackAssociationState<'AuthenticationType, Missing, 'UserName>, value: string) : AppstreamUserStackAssociationState<'AuthenticationType, Present, 'UserName> =
            state.assignments.Add(fun config -> config.StackName <- value)
            ({ assignments = state.assignments } : AppstreamUserStackAssociationState<'AuthenticationType, Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user_stack_association#user_name-1">AppstreamUserStackAssociation#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, Missing>, value: string) : AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user_stack_association#id-1">AppstreamUserStackAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, 'UserName>, value: string) : AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, 'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user_stack_association#send_email_notification-1">AppstreamUserStackAssociation#send_email_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "send_email_notification">]
        member _.SendEmailNotification(state: AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, 'UserName>, value: bool) : AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, 'UserName> =
            state.assignments.Add(fun config -> config.SendEmailNotification <- value)
            state : AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user_stack_association#send_email_notification-1">AppstreamUserStackAssociation#send_email_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "send_email_notification">]
        member _.SendEmailNotification(state: AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, 'UserName>, value: HashiCorp.Cdktf.IResolvable) : AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, 'UserName> =
            state.assignments.Add(fun config -> config.SendEmailNotification <- value)
            state : AppstreamUserStackAssociationState<'AuthenticationType, 'StackName, 'UserName>

        member _.Run(state: AppstreamUserStackAssociationState<Present, Present, Present>) : aws.AppstreamUserStackAssociation.AppstreamUserStackAssociation =
            let config = aws.AppstreamUserStackAssociation.AppstreamUserStackAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.AppstreamUserStackAssociation.AppstreamUserStackAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appstreamUserStackAssociation: missing required arguments. Must call: authentication_type, stack_name, user_name.", 9999, IsError = true)>]
        member _.Run(_: AppstreamUserStackAssociationState<_, _, _>) : aws.AppstreamUserStackAssociation.AppstreamUserStackAssociation =
            Unchecked.defaultof<aws.AppstreamUserStackAssociation.AppstreamUserStackAssociation>
