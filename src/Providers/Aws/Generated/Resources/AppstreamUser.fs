namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppstreamUserState<'AuthenticationType, 'UserName> = { assignments: ResizeArray<aws.AppstreamUser.AppstreamUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user">aws_appstream_user</a>.
    /// </summary>
    type AppstreamUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppstreamUserState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamUserState<Missing, Missing>)

        member _.Zero(()) : AppstreamUserState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamUserState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user#authentication_type-1">AppstreamUser#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: AppstreamUserState<Missing, 'UserName>, value: string) : AppstreamUserState<Present, 'UserName> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            ({ assignments = state.assignments } : AppstreamUserState<Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user#user_name-1">AppstreamUser#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: AppstreamUserState<'AuthenticationType, Missing>, value: string) : AppstreamUserState<'AuthenticationType, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : AppstreamUserState<'AuthenticationType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user#enabled-1">AppstreamUser#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AppstreamUserState<'AuthenticationType, 'UserName>, value: bool) : AppstreamUserState<'AuthenticationType, 'UserName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AppstreamUserState<'AuthenticationType, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user#enabled-1">AppstreamUser#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AppstreamUserState<'AuthenticationType, 'UserName>, value: HashiCorp.Cdktf.IResolvable) : AppstreamUserState<'AuthenticationType, 'UserName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AppstreamUserState<'AuthenticationType, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user#first_name-1">AppstreamUser#first_name</a>.
        /// </summary>
        [<CustomOperation "first_name">]
        member _.FirstName(state: AppstreamUserState<'AuthenticationType, 'UserName>, value: string) : AppstreamUserState<'AuthenticationType, 'UserName> =
            state.assignments.Add(fun config -> config.FirstName <- value)
            state : AppstreamUserState<'AuthenticationType, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user#id-1">AppstreamUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppstreamUserState<'AuthenticationType, 'UserName>, value: string) : AppstreamUserState<'AuthenticationType, 'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppstreamUserState<'AuthenticationType, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user#last_name-1">AppstreamUser#last_name</a>.
        /// </summary>
        [<CustomOperation "last_name">]
        member _.LastName(state: AppstreamUserState<'AuthenticationType, 'UserName>, value: string) : AppstreamUserState<'AuthenticationType, 'UserName> =
            state.assignments.Add(fun config -> config.LastName <- value)
            state : AppstreamUserState<'AuthenticationType, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user#send_email_notification-1">AppstreamUser#send_email_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "send_email_notification">]
        member _.SendEmailNotification(state: AppstreamUserState<'AuthenticationType, 'UserName>, value: bool) : AppstreamUserState<'AuthenticationType, 'UserName> =
            state.assignments.Add(fun config -> config.SendEmailNotification <- value)
            state : AppstreamUserState<'AuthenticationType, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_user#send_email_notification-1">AppstreamUser#send_email_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "send_email_notification">]
        member _.SendEmailNotification(state: AppstreamUserState<'AuthenticationType, 'UserName>, value: HashiCorp.Cdktf.IResolvable) : AppstreamUserState<'AuthenticationType, 'UserName> =
            state.assignments.Add(fun config -> config.SendEmailNotification <- value)
            state : AppstreamUserState<'AuthenticationType, 'UserName>

        member _.Run(state: AppstreamUserState<Present, Present>) : aws.AppstreamUser.AppstreamUser =
            let config = aws.AppstreamUser.AppstreamUserConfig()
            for setter in state.assignments do
                setter config
            aws.AppstreamUser.AppstreamUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appstreamUser: missing required arguments. Must call: authentication_type, user_name.", 9999, IsError = true)>]
        member _.Run(_: AppstreamUserState<_, _>) : aws.AppstreamUser.AppstreamUser =
            Unchecked.defaultof<aws.AppstreamUser.AppstreamUser>
