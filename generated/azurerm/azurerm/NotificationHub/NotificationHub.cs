using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NotificationHub
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub azurerm_notification_hub}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.NotificationHub.NotificationHub), fullyQualifiedName: "azurerm.notificationHub.NotificationHub", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.notificationHub.NotificationHubConfig\"}}]")]
    public class NotificationHub : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub azurerm_notification_hub} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NotificationHub(Constructs.Construct scope, string id, azurerm.NotificationHub.INotificationHubConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.NotificationHub.INotificationHubConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NotificationHub(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NotificationHub(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a NotificationHub resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NotificationHub to import.</param>
        /// <param name="importFromId">The id of the existing NotificationHub that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NotificationHub to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NotificationHub to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NotificationHub that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NotificationHub to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.NotificationHub.NotificationHub), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApnsCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.notificationHub.NotificationHubApnsCredential\"}}]")]
        public virtual void PutApnsCredential(azurerm.NotificationHub.INotificationHubApnsCredential @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NotificationHub.INotificationHubApnsCredential)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBrowserCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.notificationHub.NotificationHubBrowserCredential\"}}]")]
        public virtual void PutBrowserCredential(azurerm.NotificationHub.INotificationHubBrowserCredential @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NotificationHub.INotificationHubBrowserCredential)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGcmCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.notificationHub.NotificationHubGcmCredential\"}}]")]
        public virtual void PutGcmCredential(azurerm.NotificationHub.INotificationHubGcmCredential @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NotificationHub.INotificationHubGcmCredential)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.notificationHub.NotificationHubTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.NotificationHub.INotificationHubTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NotificationHub.INotificationHubTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApnsCredential")]
        public virtual void ResetApnsCredential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBrowserCredential")]
        public virtual void ResetBrowserCredential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGcmCredential")]
        public virtual void ResetGcmCredential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.NotificationHub.NotificationHub))!;

        [JsiiProperty(name: "apnsCredential", typeJson: "{\"fqn\":\"azurerm.notificationHub.NotificationHubApnsCredentialOutputReference\"}")]
        public virtual azurerm.NotificationHub.NotificationHubApnsCredentialOutputReference ApnsCredential
        {
            get => GetInstanceProperty<azurerm.NotificationHub.NotificationHubApnsCredentialOutputReference>()!;
        }

        [JsiiProperty(name: "browserCredential", typeJson: "{\"fqn\":\"azurerm.notificationHub.NotificationHubBrowserCredentialOutputReference\"}")]
        public virtual azurerm.NotificationHub.NotificationHubBrowserCredentialOutputReference BrowserCredential
        {
            get => GetInstanceProperty<azurerm.NotificationHub.NotificationHubBrowserCredentialOutputReference>()!;
        }

        [JsiiProperty(name: "gcmCredential", typeJson: "{\"fqn\":\"azurerm.notificationHub.NotificationHubGcmCredentialOutputReference\"}")]
        public virtual azurerm.NotificationHub.NotificationHubGcmCredentialOutputReference GcmCredential
        {
            get => GetInstanceProperty<azurerm.NotificationHub.NotificationHubGcmCredentialOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.notificationHub.NotificationHubTimeoutsOutputReference\"}")]
        public virtual azurerm.NotificationHub.NotificationHubTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.NotificationHub.NotificationHubTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apnsCredentialInput", typeJson: "{\"fqn\":\"azurerm.notificationHub.NotificationHubApnsCredential\"}", isOptional: true)]
        public virtual azurerm.NotificationHub.INotificationHubApnsCredential? ApnsCredentialInput
        {
            get => GetInstanceProperty<azurerm.NotificationHub.INotificationHubApnsCredential?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "browserCredentialInput", typeJson: "{\"fqn\":\"azurerm.notificationHub.NotificationHubBrowserCredential\"}", isOptional: true)]
        public virtual azurerm.NotificationHub.INotificationHubBrowserCredential? BrowserCredentialInput
        {
            get => GetInstanceProperty<azurerm.NotificationHub.INotificationHubBrowserCredential?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gcmCredentialInput", typeJson: "{\"fqn\":\"azurerm.notificationHub.NotificationHubGcmCredential\"}", isOptional: true)]
        public virtual azurerm.NotificationHub.INotificationHubGcmCredential? GcmCredentialInput
        {
            get => GetInstanceProperty<azurerm.NotificationHub.INotificationHubGcmCredential?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.notificationHub.NotificationHubTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespaceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamespaceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
