Vue.component('c-applications',{
    template: /*html*/
    `
    <div>
    <v-form ref="form" class="pb-4"  v-model="valid"  lazy-validation>

        <v-text-field v-model="name_app" class="col-lg-5 col-md-7 col-sm-12 pb-0 mb-0" :counter="25" :rules="nameRules"  label="Aplication Name"  
            required ></v-text-field> 
        <v-checkbox  v-model="checkbox1" class="col-sm-3 col-md-3  col-lg-2 pt-0 pb-0 mt-0 mb-0 text-center"  label="Enable aplication?" required color="success"></v-checkbox>
        <v-btn  :disabled="!valid"  :loading="loading"   rounded  color="success"   class="pb-0 col-sm-1"  @click="insertAPP">  Add</v-btn> 

    </v-form>
    <v-data-table :headers="headers" :items="ListApps" sort-by="id_app" class="elevation-1" >
    <template v-slot:top>
      <v-toolbar flat>
        <v-toolbar-title>My applications</v-toolbar-title>
        
        <v-spacer></v-spacer>
        <v-dialog v-model="dialog"  max-width="500px" >
         
          <v-card>
            <v-card-title>
            
              <v-badge :content="editedItem.id_app" overlap color="deep-purple accent-4">  
              <span class="headline">{{ formTitle }}</span>           
              </v-badge>
            </v-card-title>
            
            <v-card-text>
              <v-container>
                <v-row>                
                  <v-col cols="12" sm="8" md="8">
                    <v-text-field v-model="editedItem.name_app" label="Application Name"></v-text-field>
                  </v-col>
                  <v-col cols="12" sm="4" md="4">
                    <v-checkbox v-model="editedItem.Is_Active" class="center" label="Activate" required color="success"></v-checkbox>
                  </v-col>                 
                </v-row>
              </v-container>
            </v-card-text>

            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="error" small rounded @click="close">
                <v-icon left>
                    mdi-arrow-left
                </v-icon>              
                Cancel
              </v-btn>
              <v-btn  color="success" small rounded  @click="save">
                <v-icon left>
                    mdi-pencil
                </v-icon>
                Save
              </v-btn>
            </v-card-actions>
          </v-card>
        </v-dialog>
        <v-dialog v-model="dialogDelete" max-width="500px">
          <v-card>
            <v-card-title class="headline">Are you sure you want to delete this item?</v-card-title>
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="error" small elevation="2" rounded  @click="closeDelete">
                <v-icon left>
                    mdi-cancel
                </v-icon> 
                No
              </v-btn>
              <v-btn  color="success" small elevation="2" rounded  @click="deleteItemConfirm">
                <v-icon left>
                    mdi-checkbox-marked-circle
                </v-icon> 
              YES
              </v-btn>
              <v-spacer></v-spacer>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-toolbar>
    </template>
    <template v-slot:item.actions="{ item }">
      <v-icon small class="mr-2" id="icon-edit" @click="editItem(item)">
        mdi-pencil
      </v-icon>
      <v-icon small id="icon-cancel"  @click="deleteItem(item)">
        mdi-delete
      </v-icon>
    </template>
    <template v-slot:item.Is_Active="{ item }">
    <v-checkbox v-model="item.Is_Active" @click="updateCheckbox(item.id_app,item.Is_Active)" required color="success"></v-checkbox>
    </template>
  </v-data-table>
  </div>
    
    `,
computed: {    
    ...Vuex.mapState(['ListApps','checkbox','loading']),
    formTitle () {
        return  'Edit App'
      } 
},
watch: {
    dialog (val) {
      val || this.close()
    },
    dialogDelete (val) {
      val || this.closeDelete()
    },
  },
data(){
    return{
        valid: true,
        name_app: "",       
        nameRules: [
            v => !!v || 'Name is required',
            v => (v && v.length <= 25) || 'Name must be less than 25 characters',
          ],
          checkbox1: false,
          search: '',
          headers: [
            {
              text: 'Application ID',
              align: 'start',              
              value: 'id_app',
            },
            { text: 'Application Name', value: 'name_app' },
            { text: ' Enabled', value: 'Is_Active' },
            { text: 'Actions', value: 'actions', sortable: false }
            
          ],         
          dialog: false,
          dialogDelete: false,
          editedIndex: -1,
         editedItem: {
                id_app: 0,
                name_app: '',
                Is_Active: false

      },
      defaultItem: {
        id_app: 0,
        name_app: '',
        Is_Active: false
      }

    }
},
methods: {
    ...Vuex.mapActions(['updateCheckbox','insertApp','update_app','delete_app']),
    //...Vuex.mapMutations(['','']),

    updateCheckbox (id_app,ischeked) 
    {
       
        var CurrentApp = this.GetCurrentApp(id_app);
        CurrentApp.Is_Active =ischeked;    
        store.state.loading = true;    
        this.update_app(CurrentApp); // update by store    
    },
    insertAPP(){
       var validado = this.$refs.form.validate();
        
        if(validado){
            var app = {
                id_app: 0,
                name_app: this.name_app,
                Is_Active: this.checkbox1
            }
            store.state.loading = true;
            this.insertApp(app);  // insert by store  
        }  
              
    },
    update(id_app,ischeked)
    {

    },
    GetCurrentApp(id_app)
    {
        return this.ListApps.find((x) => x.id_app == id_app);
    },
    editItem (item) {
        this.editedIndex = this.ListApps.indexOf(item)
        this.editedItem = Object.assign({}, item)
        this.dialog = true
      },

      deleteItem (item) {
        this.editedIndex = this.ListApps.indexOf(item)
        this.editedItem = Object.assign({}, item)
        this.dialogDelete = true
      },
      deleteItemConfirm () {
          // Eliminar en bd
          const item =  this.GetCurrentApp(this.editedItem.id_app);
        this.delete_app(item);
        //this.ListApps.splice(this.editedIndex, 1)
        this.closeDelete()
      },
      close () {
        this.dialog = false
        this.$nextTick(() => {
          this.editedItem = Object.assign({}, this.defaultItem)
          this.editedIndex = -1
        })
      }, 
      closeDelete () {
        this.dialogDelete = false
        this.$nextTick(() => {
          this.editedItem = Object.assign({}, this.defaultItem)
          this.editedIndex = -1
        })
      },
      save () 
      {
        if (this.editedIndex > -1) 
        {//Editar
            var CurrentApp = this.GetCurrentApp(this.editedItem.id_app);
            CurrentApp.name_app = this.editedItem.name_app;
            CurrentApp.Is_Active = this.editedItem.Is_Active;
            this.update_app(CurrentApp);
          //Object.assign(this.ListApps[this.editedIndex], this.editedItem)          
        } 
        this.close();
      }
}

})