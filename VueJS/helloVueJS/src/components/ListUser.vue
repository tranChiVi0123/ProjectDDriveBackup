<template>
  <div class="list-user">
    <user v-for="(user,index) in listUser" v-bind:key="index" v-bind:user="user" 
    v-on:HandleDelete="HandleDelete" />
  </div>
</template>

<script>
import User from "./User.vue";
export default {
  name: "list-user",
  data() {
    return {};
  },
  components: {
    User
  },
  props: {
    listUser: Array
  },
  methods:{
      HandleDelete(email){
          console.log("ListUser Called");
          this.$emit("HandleDelete",email);
      }
  }
};
</script>

<style>
.list-user {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
}
.list-user .user {
  padding: 30px;
  margin-bottom: 0px;
  border: 1px slide yellow;
  width: calc(33.3333% -20px);
}
</style>