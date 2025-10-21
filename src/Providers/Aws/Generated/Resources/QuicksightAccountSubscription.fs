namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> = { assignments: ResizeArray<aws.QuicksightAccountSubscription.QuicksightAccountSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription">aws_quicksight_account_subscription</a>.
    /// </summary>
    type QuicksightAccountSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightAccountSubscriptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightAccountSubscriptionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : QuicksightAccountSubscriptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightAccountSubscriptionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#account_name-1">QuicksightAccountSubscription#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: QuicksightAccountSubscriptionState<Missing, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<Present, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : QuicksightAccountSubscriptionState<Present, 'AuthenticationMethod, 'Edition, 'NotificationEmail>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#authentication_method-1">QuicksightAccountSubscription#authentication_method</a>.
        /// </summary>
        [<CustomOperation "authentication_method">]
        member _.AuthenticationMethod(state: QuicksightAccountSubscriptionState<'AccountName, Missing, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, Present, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.AuthenticationMethod <- value)
            ({ assignments = state.assignments } : QuicksightAccountSubscriptionState<'AccountName, Present, 'Edition, 'NotificationEmail>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#edition-1">QuicksightAccountSubscription#edition</a>.
        /// </summary>
        [<CustomOperation "edition">]
        member _.Edition(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, Missing, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, Present, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.Edition <- value)
            ({ assignments = state.assignments } : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, Present, 'NotificationEmail>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#notification_email-1">QuicksightAccountSubscription#notification_email</a>.
        /// </summary>
        [<CustomOperation "notification_email">]
        member _.NotificationEmail(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, Missing>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, Present> =
            state.assignments.Add(fun config -> config.NotificationEmail <- value)
            ({ assignments = state.assignments } : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#active_directory_name-1">QuicksightAccountSubscription#active_directory_name</a>.
        /// </summary>
        [<CustomOperation "active_directory_name">]
        member _.ActiveDirectoryName(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.ActiveDirectoryName <- value)
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#admin_group-1">QuicksightAccountSubscription#admin_group</a>.
        /// </summary>
        [<CustomOperation "admin_group">]
        member _.AdminGroup(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: seq<string>) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.AdminGroup <- (value |> Seq.toArray))
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#author_group-1">QuicksightAccountSubscription#author_group</a>.
        /// </summary>
        [<CustomOperation "author_group">]
        member _.AuthorGroup(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: seq<string>) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.AuthorGroup <- (value |> Seq.toArray))
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#aws_account_id-1">QuicksightAccountSubscription#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#contact_number-1">QuicksightAccountSubscription#contact_number</a>.
        /// </summary>
        [<CustomOperation "contact_number">]
        member _.ContactNumber(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.ContactNumber <- value)
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#directory_id-1">QuicksightAccountSubscription#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#email_address-1">QuicksightAccountSubscription#email_address</a>.
        /// </summary>
        [<CustomOperation "email_address">]
        member _.EmailAddress(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.EmailAddress <- value)
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#first_name-1">QuicksightAccountSubscription#first_name</a>.
        /// </summary>
        [<CustomOperation "first_name">]
        member _.FirstName(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.FirstName <- value)
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#iam_identity_center_instance_arn-1">QuicksightAccountSubscription#iam_identity_center_instance_arn</a>.
        /// </summary>
        [<CustomOperation "iam_identity_center_instance_arn">]
        member _.IamIdentityCenterInstanceArn(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.IamIdentityCenterInstanceArn <- value)
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#id-1">QuicksightAccountSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#last_name-1">QuicksightAccountSubscription#last_name</a>.
        /// </summary>
        [<CustomOperation "last_name">]
        member _.LastName(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.LastName <- value)
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#reader_group-1">QuicksightAccountSubscription#reader_group</a>.
        /// </summary>
        [<CustomOperation "reader_group">]
        member _.ReaderGroup(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: seq<string>) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.ReaderGroup <- (value |> Seq.toArray))
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#realm-1">QuicksightAccountSubscription#realm</a>.
        /// </summary>
        [<CustomOperation "realm">]
        member _.Realm(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: string) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.Realm <- value)
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_subscription#timeouts-1">QuicksightAccountSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>, value: aws.QuicksightAccountSubscription.QuicksightAccountSubscriptionTimeouts) : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QuicksightAccountSubscriptionState<'AccountName, 'AuthenticationMethod, 'Edition, 'NotificationEmail>

        member _.Run(state: QuicksightAccountSubscriptionState<Present, Present, Present, Present>) : aws.QuicksightAccountSubscription.QuicksightAccountSubscription =
            let config = aws.QuicksightAccountSubscription.QuicksightAccountSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightAccountSubscription.QuicksightAccountSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightAccountSubscription: missing required arguments. Must call: account_name, authentication_method, edition, notification_email.", 9999, IsError = true)>]
        member _.Run(_: QuicksightAccountSubscriptionState<_, _, _, _>) : aws.QuicksightAccountSubscription.QuicksightAccountSubscription =
            Unchecked.defaultof<aws.QuicksightAccountSubscription.QuicksightAccountSubscription>
