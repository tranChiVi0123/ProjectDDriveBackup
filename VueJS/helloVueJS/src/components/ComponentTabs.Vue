<template>
  <div class="component-tabs">
    <div class="component-title">
      <span>{{title}}<ion-icon name="leaf-outline"></ion-icon></span>
    </div>
  </div>
</template>

<script>
export default {
  name: "component-tabs",
  props: {
    title: String
  },
  data() {
    return {};
  }
};
</script>

<style>
.component-title{
    border: 2px solid blue;
    padding: 15px 30px;
    display: flex;
    justify-content: baseline;
}
.tabs-header{
    margin: 0;
    padding: 0;
    display: flex;
    list-style-type: none;
    
}
.tabs-header li{
    padding: 8px 15px;
    background-color: brown;
    transition: all .3s ease;
}
.tabs-header li:hover{
    background-color: cornsilk;
}
.tabs-content{
    border: 2px solid seagreen;
    margin-top: 2px;
    padding: 2px;
    text-align: left;
}
</style>